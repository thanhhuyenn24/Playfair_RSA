using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair_RSA
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Input/Output
        private void openBtn_Click(object sender, EventArgs e)
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

        private void exportBtn_Click(object sender, EventArgs e)
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

        #region Generate Key
        long P, Q, N, E, D, PhiN;

        // Generate random prime number between 11 and 101
        private long GetRandomPrime()
        {
            Random rnd = new Random();
            long num;
            do
            {
                num = rnd.Next(11, 101);
            } while (!CheckPrime(num));
            return num;
        }

        // Check if a number is prime
        private bool CheckPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (long i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        // Check if two numbers are coprime (gcd = 1)
        private bool IsCoprime(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a == 1;
        }

        // Extended Euclidean algorithm to find modular inverse
        private (long gcd, long x, long y) ExtendedGCD(long a, long b)
        {
            if (b == 0)
                return (a, 1, 0);

            var result = ExtendedGCD(b, a % b);
            long x = result.y;
            long y = result.x - (a / b) * result.y;
            return (result.gcd, x, y);
        }

        // Fast modular exponentiation
        private long ModPow(long baseNum, long exponent, long modulus)
        {
            long result = 1;
            baseNum = baseNum % modulus;
            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    result = (result * baseNum) % modulus;
                exponent = exponent >> 1;
                baseNum = (baseNum * baseNum) % modulus;
            }
            return result;
        }

        // Convert long to byte array (little endian)
        private byte[] LongToByteArray(long value)
        {
            byte[] bytes = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                bytes[i] = (byte)(value >> (i * 8));
            }
            return bytes;
        }

        // Convert byte array to long (little endian)
        private long ByteArrayToLong(byte[] bytes)
        {
            long value = 0;
            for (int i = 0; i < Math.Min(bytes.Length, 8); i++)
            {
                value |= ((long)bytes[i]) << (i * 8);
            }
            return value;
        }

        // Calculate maximum safe block size for given N
        private int GetMaxBlockSize(long N)
        {
            // We need to ensure that the largest possible value from blockSize bytes < N
            int blockSize = 1;
            long maxValue = 255; // Maximum value for 1 byte

            while (maxValue < N && blockSize < 8)
            {
                blockSize++;
                maxValue = (maxValue << 8) | 0xFF;
            }

            // Use one byte less for safety margin
            return Math.Max(1, blockSize - 1);
        }

        // Generate RSA keys
        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            if (tbP.Text == string.Empty && tbQ.Text == string.Empty) ClearAllFields();

            // Check if user provided P and Q values
            bool userProvidedP = !string.IsNullOrWhiteSpace(tbP.Text);
            bool userProvidedQ = !string.IsNullOrWhiteSpace(tbQ.Text);

            if (userProvidedP || userProvidedQ)
            {
                // Validate user input
                if (!userProvidedP || !userProvidedQ)
                {
                    MessageBox.Show("Please provide both P and Q values or leave both empty for auto-generation.", "Input Error");
                    return;
                }

                if (!long.TryParse(tbP.Text.Trim(), out P) ||
                    !long.TryParse(tbQ.Text.Trim(), out Q))
                {
                    MessageBox.Show("Please enter valid integer values for P and Q.", "Input Error");
                    return;
                }

                // Validate prime numbers
                if (!CheckPrime(P))
                {
                    MessageBox.Show("P must be a prime number.", "Validation Error");
                    return;
                }

                if (!CheckPrime(Q))
                {
                    MessageBox.Show("Q must be a prime number.", "Validation Error");
                    return;
                }

                if (P == Q)
                {
                    MessageBox.Show("P and Q must be different prime numbers.", "Validation Error");
                    return;
                }
            }
            else
            {
                // Auto-generate two different prime numbers
                P = GetRandomPrime();
                do
                {
                    Q = GetRandomPrime();
                } while (P == Q);

                tbP.Text = P.ToString();
                tbQ.Text = Q.ToString();
            }

            // Calculate RSA parameters
            GenerateRSAKeys();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbD.Text == string.Empty)
            {
                MessageBox.Show("Please generate keys first!", "Generate Key Required");
                return;
            }
            string plaintext = InputText.Text.Trim();
            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("Please enter text to encrypt.", "Input Required");
                return;
            }

            try
            {
                string ciphertext = EncryptRSA(plaintext);
                OutputText.Text = ciphertext;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption failed: {ex.Message}", "Encryption Error");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbD.Text == string.Empty)
            {
                MessageBox.Show("Please generate keys first!", "Generate Key Required");
                return;
            }
            string base64Input = InputText.Text.Trim();

            if (string.IsNullOrEmpty(base64Input))
            {
                MessageBox.Show("No data to decrypt!", "Input Required");
                return;
            }

            try
            {
                string decryptedText = DecryptRSA(base64Input);
                OutputText.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Decryption failed: {ex.Message}", "Decryption Error");
            }
        }

        // Calculate RSA key parameters
        private void GenerateRSAKeys()
        {
            try
            {
                //n=p*q
                N = P * Q;
                tbN.Text = N.ToString();
                //Phi(n)=(p-1)*(q-1)
                PhiN = (P - 1) * (Q - 1);
                tbPhiN.Text = PhiN.ToString();
                //e is random number which 0< e <phi(n) and is coProme with Phi(n)
                do
                {
                    if (tbE.Text == "")
                    {
                        Random RSA_rd = new Random();
                        E = RSA_rd.Next(2, (int)PhiN);
                    }
                    else
                    {
                        E = long.Parse(tbE.Text);
                    }
                }
                while (!IsCoprime(E, PhiN));
                tbE.Text = E.ToString();
                //d = revert of e
                D = 0;
                long i = 2;
                while (((1 + i * PhiN) % E) != 0 || D <= 0)
                {
                    i++;
                    D = (1 + i * PhiN) / E;
                }
                tbD.Text = D.ToString();

                // Show block size info for Vietnamese text support
                int blockSize = GetMaxBlockSize(N);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating keys: {ex.Message}", "Error");
            }
        }


        // Clear all input fields
        private void ClearAllFields()
        {
            tbP.Text = tbQ.Text = tbPhiN.Text = tbN.Text =
            tbE.Text = tbD.Text = InputText.Text = OutputText.Text = string.Empty;
        }

        // RSA Encryption with Base64 encoding - Fixed for Vietnamese
        private string EncryptRSA(string plaintext)
        {
            List<long> encryptedValues = new List<long>();
            byte[] bytes = Encoding.UTF8.GetBytes(plaintext);

            // Calculate maximum block size based on N
            int blockSize = GetMaxBlockSize(N);

            // Process data in blocks instead of individual bytes
            for (int i = 0; i < bytes.Length; i += blockSize)
            {
                // Get block of bytes
                int currentBlockSize = Math.Min(blockSize, bytes.Length - i);
                byte[] block = new byte[currentBlockSize];
                Array.Copy(bytes, i, block, 0, currentBlockSize);

                // Convert block to integer
                long m = ByteArrayToLong(block);

                // Ensure m < N for RSA
                if (m >= N)
                {
                    long recommendedMinPrime = (long)Math.Sqrt(Math.Pow(256, blockSize + 1)) + 100;
                    throw new Exception($"Block value {m} is too large for N={N}. Try using larger prime numbers (P, Q > {recommendedMinPrime}).");
                }

                // Encrypt block
                long c = ModPow(m, E, N);
                encryptedValues.Add(c);
            }

            // Convert to Base64 with length prefixes
            List<byte> allBytes = new List<byte>();
            foreach (long encValue in encryptedValues)
            {
                byte[] longBytes = LongToByteArray(encValue);

                // Remove trailing zeros to save space
                int actualLength = 8;
                while (actualLength > 1 && longBytes[actualLength - 1] == 0)
                {
                    actualLength--;
                }

                // Store length prefix (1 byte) followed by data
                allBytes.Add((byte)actualLength);
                for (int i = 0; i < actualLength; i++)
                {
                    allBytes.Add(longBytes[i]);
                }
            }

            return Convert.ToBase64String(allBytes.ToArray());
        }

        // RSA Decryption from Base64 - Fixed for Vietnamese
        private string DecryptRSA(string base64Ciphertext)
        {
            byte[] encryptedBytes = Convert.FromBase64String(base64Ciphertext);
            List<byte> decryptedBytes = new List<byte>();
            int i = 0;

            int blockSize = GetMaxBlockSize(N);

            while (i < encryptedBytes.Length)
            {
                // Read length prefix
                int length = encryptedBytes[i];
                i++;

                // Read the encrypted value bytes
                byte[] longBytes = new byte[8]; // Initialize with zeros
                for (int j = 0; j < length && i < encryptedBytes.Length; j++)
                {
                    longBytes[j] = encryptedBytes[i];
                    i++;
                }

                // Convert back to long and decrypt
                long c = ByteArrayToLong(longBytes);
                long m = ModPow(c, D, N);

                // Convert decrypted value back to bytes
                byte[] blockBytes = LongToByteArray(m);

                // Add only the significant bytes (up to block size)
                for (int j = 0; j < blockSize && j < blockBytes.Length; j++)
                {
                    if (blockBytes[j] != 0 || (j == 0 && m == 0)) // Include zero bytes except trailing zeros
                    {
                        decryptedBytes.Add(blockBytes[j]);
                    }
                    else if (j > 0 && blockBytes[j] == 0)
                    {
                        // Check if this is a meaningful zero or just padding
                        bool hasMoreNonZeroBytes = false;
                        for (int k = j + 1; k < Math.Min(blockSize, blockBytes.Length); k++)
                        {
                            if (blockBytes[k] != 0)
                            {
                                hasMoreNonZeroBytes = true;
                                break;
                            }
                        }
                        if (hasMoreNonZeroBytes)
                        {
                            decryptedBytes.Add(blockBytes[j]);
                        }
                        else
                        {
                            break; // Stop at trailing zeros
                        }
                    }
                }
            }

            // Convert bytes back to string using UTF-8
            return Encoding.UTF8.GetString(decryptedBytes.ToArray());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        #endregion
    }
}
