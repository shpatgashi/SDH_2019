using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SulmimiKoditCezaritFrekuenca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counter = 0;

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            string ciphertext = txtCiphertext.Text;
            ciphertext = ciphertext.ToUpper();
            int celesi = getKey(ciphertext, counter);
            txtPlaintext.Text = Dekripto(ciphertext, celesi);
            counter++;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                filePath = opf.FileName;
            }
            if (File.Exists(filePath))
            {
                using (StreamReader st = new StreamReader(filePath))
                {
                    txtCiphertext.Text = StreamReader.ReadToEnd();
                }
            }
        }
    }
}
