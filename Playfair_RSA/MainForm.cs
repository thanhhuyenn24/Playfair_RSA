using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair_RSA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PlayfairBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Playfair playfairForm = new Playfair();
            playfairForm.ShowDialog();
            this.Show();
        }

        private void RSABtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSA rsaForm = new RSA();
            rsaForm.ShowDialog();
            this.Show();
        }
    }
}
