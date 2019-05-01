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
                using (StreamReader sr = new StreamReader(filePath))
                {
                    txtCiphertext.Text = sr.ReadToEnd();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string plaintext = txtPlaintext.Text;
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                StreamWriter sw = new StreamWriter(File.Create(path));
                sw.Write(plaintext);
                sw.Dispose();

            }
        }

        private String Dekripto(string ciphertext, int celesi)
        {
            StringBuilder plaintext = new StringBuilder(ciphertext);

            for (int i = 0; i < ciphertext.Length; i++)
            {
                char chA = ciphertext[i];
                if(chA >= 'A' && chA <= 'Z')
                {
                    int pozita = (chA - 'A');

                    pozita = (26 + pozita - celesi) % 26;
                    char encchA;
                    encchA = (char)((pozita + 'A'));

                    plaintext[i] = encchA;

                }
            }
            return plaintext.ToString();
        }
    }
}
