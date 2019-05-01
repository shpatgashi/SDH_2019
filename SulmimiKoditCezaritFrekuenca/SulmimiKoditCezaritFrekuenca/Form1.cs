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
        private int getKey(string text, int count)
        {
            int key = 0;
            char[] frequency = { 'E', 'T', 'A', 'O', 'I', 'N', 'S', 'R', 'H', 'L', 'D', 'C', 'U', 'M', 'F', 'G', 'P', 'W', 'Y', 'B', 'V', 'K', 'J', 'X', 'Z', 'Q' };

            int[] c = new int[(int)char.MaxValue];


            foreach(char a in text)
            {
                if(a>= 65 && a <= 90)
                {

                    c[(int)a]++;
                }
                    
            }

            int maxValue = c.Max();
            for(int i = 0; i < c.Length; i++)
            {
                if(c[i] == maxValue)
                {
                    key = i;
                    break;
                }
            }
 

            return((26+key- frequency[count%26])%26);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPlaintext.Text = null;
            counter = 0;

        }

        private void txtCiphertext_TextChanged(object sender, EventArgs e)
        {
            txtCiphertext.ScrollBars = ScrollBars.Vertical;
        }

        private void txtPlaintext_TextChanged(object sender, EventArgs e)
        {
            txtPlaintext.ScrollBars = ScrollBars.Vertical;
        }
    }
}
