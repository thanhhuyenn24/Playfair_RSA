using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Playfair_RSA
{
    public partial class Playfair : Form
    {
        // constants
        private const string ALPHA_5 = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; // J excluded
        private const string ALPHA_6 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private bool suppressTextChanged = false;
        private TextBox[,] matrixArray = new TextBox[6, 6];
        public Playfair()
        {
            InitializeComponent();
            FindAllMatrixElements();
        }

        private void BackPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Input
        private void Openbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text File (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string content = System.IO.File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                        InputText.Text = content;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                    }
                }
            }
        }

        #endregion

        #region Output
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text File (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = saveFileDialog.FileName;
                        System.IO.File.WriteAllText(filePath, OutputText.Text, Encoding.UTF8);
                        MessageBox.Show("Đã lưu file thành công!", "Thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                    }
                }
            }
        }

        private void SwapBtn_Click(object sender, EventArgs e)
        {
            InputText.Text = OutputText.Text;
            OutputText.Text = string.Empty;
        }
        #endregion

        #region Playfair Key

        //-------------------------------------GENERATE MATRIX-------------------------------------
        private void Key_TextChanged(object sender, EventArgs e)
        {
            if (suppressTextChanged) return;
            var tb = sender as TextBox;
            if (tb == null) return;

            bool use5 = is5x5();
            string allowedSource = use5 ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ" : "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            //Filter input but preserve the caret position correctly
            int selStart = tb.SelectionStart;
            string original = tb.Text;

            //Function to check if character is valid (compared with allowedSource in uppercase)
            Func<char, bool> isAllowedChar = c => allowedSource.Contains(char.ToUpperInvariant(c));
            string filtered = new string(original.Where(isAllowedChar).ToArray());

            //If 5x5 => convert J->I in the input (before removing duplicates)
            if (use5)
                filtered = new string(filtered.Select(c => char.ToUpperInvariant(c) == 'J' ? 'I' : c).ToArray());
            else
                filtered = filtered.ToUpperInvariant(); // Normalize to uppercase for 6x6

            //Count number of removed characters *before* the caret to restore caret correctly
            int removedBeforeCursor = original.Take(selStart).Count(ch => !isAllowedChar(ch));
            int newCursor = Math.Max(0, selStart - removedBeforeCursor);

            if (original != filtered)
            {
                suppressTextChanged = true;
                tb.Text = filtered;
                tb.SelectionStart = Math.Min(filtered.Length, newCursor);
                suppressTextChanged = false;
            }

            //Update the matrix (create normalized key inside)
            GenerateMatrix(use5 ? 5 : 6, filtered);
        }

        //Radio button change: only process when Checked == true
        private void radio5x5_CheckedChanged(object sender, EventArgs e)
        {
            if (!radio5x5.Checked) return;
            clearMatrix6thRowAndColumn();
            GenerateMatrix(5, Key.Text);
        }

        private void radio6x6_CheckedChanged(object sender, EventArgs e)
        {
            if (!radio6x6.Checked) return;
            GenerateMatrix(6, Key.Text);
        }

        //Build normalized key & fill the matrix
        private void GenerateMatrix(int size, string rawKey)
        {
            string allowed = (size == 5) ? ALPHA_5 : ALPHA_6;

            //BuildKey: replace (J->I) already applied in TextChanged, but map again for safety
            string normalized = BuildKey(rawKey, allowed, size == 5 ? (Func<char, char>)(c => c == 'J' ? 'I' : c) : null);

            //Append remaining characters from allowed
            StringBuilder final = new StringBuilder(normalized);
            foreach (char c in allowed)
                if (!normalized.Contains(c))
                    final.Append(c);

            //Fill matrixArray
            int idx = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    char ch = final[idx];
                    matrixArray[i, j].Text = ch.ToString();
                    matrixArray[i, j].ForeColor = normalized.Contains(ch) ? Color.Red : Color.Black;
                    idx++;
                }

            //If 5x5, clear unused cells (optional)
            if (size == 5)
                clearMatrix6thRowAndColumn();
        }

        private string BuildKey(string input, string allowedChars, Func<char, char> mapper = null)
        {
            var seen = new HashSet<char>();
            var sb = new StringBuilder();
            foreach (char ch in input.ToUpperInvariant())
            {
                char c = mapper != null ? mapper(ch) : ch;
                if (!allowedChars.Contains(c)) continue;
                if (seen.Add(c)) sb.Append(c);
            }
            return sb.ToString();
        }

        //Utility: find all TextBox controls once
        private void FindAllMatrixElements()
        {
            //Assume TextBox names are "A1", "A2", ... in row-major order
            int index = 1;
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    string name = "A" + index++;
                    Control[] found = this.Controls.Find(name, true); //Recursive search
                    if (found != null && found.Length > 0 && found[0] is TextBox tb)
                        matrixArray[i, j] = tb;
                    else
                        matrixArray[i, j] = new TextBox(); //Avoid null; or throw exception if desired
                }
            }
        }

        private void clearMatrix6thRowAndColumn()
        {
            for (int i = 0; i < 6; i++)
            {
                matrixArray[i, 5].Clear();
                matrixArray[5, i].Clear();
            }
        }

        //Stub helpers (unchanged)
        private bool is5x5() => radio5x5.Checked;
        private bool is6x6() => radio6x6.Checked;

        //-------------------------------------ENCRYPT/DECRYPT-------------------------------------
        private string NormalizeInput(string text, int size, bool removeNonLetters = false)
        {
            text = new string(text.Where(char.IsLetterOrDigit).ToArray()).ToUpperInvariant();
            if (size == 5)
            {
                text = text.Replace('J', 'I');
                if (removeNonLetters) text = new string(text.Where(char.IsLetter).ToArray());
            }
            return text;
        }

        private (int, int) FindPosition(char c, int size)
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (matrixArray[i, j].Text[0] == c)
                        return (i, j);
            throw new ArgumentException($"Character not found in matrix: {c}");
        }

        private string ProcessPlayfair(string text, int size, int rowShift, int colShift)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < text.Length; i += 2)
            {
                (int x1, int y1) = FindPosition(text[i], size);
                (int x2, int y2) = FindPosition(text[i + 1], size);

                if (x1 == x2) // same row
                {
                    output.Append(matrixArray[x1, (y1 + colShift + size) % size].Text);
                    output.Append(matrixArray[x2, (y2 + colShift + size) % size].Text);
                }
                else if (y1 == y2) // same column
                {
                    output.Append(matrixArray[(x1 + rowShift + size) % size, y1].Text);
                    output.Append(matrixArray[(x2 + rowShift + size) % size, y2].Text);
                }
                else // rectangle
                {
                    output.Append(matrixArray[x1, y2].Text);
                    output.Append(matrixArray[x2, y1].Text);
                }
            }

            return output.ToString();
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            int size = is6x6() ? 6 : 5;
            string text = NormalizeInput(InputText.Text, size, size == 5);

            // create digraphs with padding
            StringBuilder padded = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                char a = text[i];
                char b = (i + 1 < text.Length) ? text[i + 1] : 'X';
                if (a == b) { padded.Append(a).Append('X'); i--; }
                else padded.Append(a).Append(b);
            }

            string encrypted = ProcessPlayfair(padded.ToString(), size, +1, +1);
            OutputText.Text = encrypted;
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            int size = is6x6() ? 6 : 5;
            string text = NormalizeInput(InputText.Text, size, size == 5);

            string decrypted = ProcessPlayfair(text, size, -1, -1);

            // remove padding
            StringBuilder clean = new StringBuilder(decrypted);
            for (int i = 1; i < clean.Length - 1; i++)
                if (clean[i] == 'X' && clean[i - 1] == clean[i + 1])
                    clean.Remove(i--, 1);
            if (clean.Length > 0 && clean[clean.Length - 1] == 'X')
                clean.Length = clean.Length - 1;

            OutputText.Text = clean.ToString();
        }
        #endregion
    }
}
