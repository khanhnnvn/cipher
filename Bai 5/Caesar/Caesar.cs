using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Caesar
{
    public partial class Caesar : Form
    {
        private CaesarCipher objCipher = new CaesarCipher();
        public Caesar()
        {
            InitializeComponent();
        }

        private void Caesar_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alphabetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFiledialog = new OpenFileDialog();
            openFiledialog.Filter = "Text Files|*.txt";
            if (openFiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string alphabet = File.ReadAllText(openFiledialog.FileName);
                textBoxCharacter.Text = alphabet;
                objCipher.Character = alphabet;
                objCipher.CountCharater = alphabet.Length;
                
                MessageBox.Show("Number: "+alphabet.Length.ToString(), "Number of characters", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = textBoxPlaintext.Text.Trim();
            string keyText = textBoxShift.Text.Trim();
            textBoxInputCount.Text = plainText.Length.ToString();

            if (plainText == "" || keyText == "")
                MessageBox.Show("Please fill data on plain text and key box", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    textBoxCiphertext.Text = objCipher.Encrypt(plainText, keyText);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            textBoxOutputCount.Text = textBoxCiphertext.Text.Trim().Length.ToString();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = textBoxCiphertext.Text.Trim();
            string keyText = textBoxShift.Text.Trim();
            textBoxInputCount.Text = cipherText.Length.ToString();

            if (cipherText == "" || keyText == "")
                MessageBox.Show("Please fill data on cipher text and key box", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    textBoxPlaintext.Text = objCipher.Decrypt(cipherText, keyText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void plaintextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFiledialog = new OpenFileDialog();
            openFiledialog.Filter = "Text Files|*.txt";
            if (openFiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string alphabet = File.ReadAllText(openFiledialog.FileName);
                textBoxPlaintext.Text = alphabet;
                textBoxInputCount.Text = alphabet.Length.ToString();
                //MessageBox.Show("Number: " + alphabet.Length.ToString(), "Number of characters", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poem = textBoxPlaintext.Text.Trim();
            long countinput = long.Parse(textBoxInputCount.Text.Trim());

            Dictionary<char, long> freqs = objCipher.letterFreqs(poem);
            foreach (char k in freqs.Keys)
            {
                textBox1.AppendText(string.Format("Character '{0}' occurs {1:N} times {2:0.###E-000} \n", k, freqs[k], ((float)freqs[k] * 100) / (float)countinput));
            }
        }
    }
}
