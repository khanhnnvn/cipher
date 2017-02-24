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

        //Button for Encrypt
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = textBoxPlaintext.Text.Trim();
            string shiftText = textBoxShift.Text.Trim();
            //int shiftInt = int.Parse(textBoxShift.Text.Trim());
            string charaterText = textBoxCharacter.Text.Trim();
            int lengthText = plainText.Length;
            if (plainText == "" || shiftText == null || charaterText == "")
                MessageBox.Show("Please fill data on plain text and key box", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    textBoxCiphertext.Text = objCipher.Encrypt(plainText, charaterText, int.Parse(shiftText), lengthText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Button Decrypt
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string cryptText = textBoxCiphertext.Text.Trim();
            string shiftText = textBoxShift.Text.Trim();
            string charaterText = textBoxCharacter.Text.Trim();
            int lengthText = cryptText.Length;
            if (cryptText == "" || shiftText == null || charaterText == "")
                MessageBox.Show("Please fill data on plain text and key box", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    textBoxPlaintext.Text = objCipher.Decrypt(cryptText, charaterText, int.Parse(shiftText), lengthText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

       
        //Count length character realtime
        private void textBoxCharacter_TextChanged(object sender, EventArgs e)
        {
            textBoxCountCharacter.Text = textBoxCharacter.Text.Trim().Length.ToString();
        }

        //Count length plain text realtime
        private void textBoxPlaintext_TextChanged(object sender, EventArgs e)
        {
            textBoxPlainCount.Text = textBoxPlaintext.Text.Trim().Length.ToString();
        }

        //Count length cripher text realtime
        private void textBoxCiphertext_TextChanged(object sender, EventArgs e)
        {
            textBoxCripherCount.Text = textBoxCiphertext.Text.Trim().Length.ToString();
        }

        //Menu Open character file
        private void characterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFiledialog = new OpenFileDialog();
            openFiledialog.Filter = "Text Files|*.txt";
            if (openFiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string alphabet = File.ReadAllText(openFiledialog.FileName);
                textBoxCharacter.Text = alphabet;

                //MessageBox.Show("Number: " + alphabet.Length.ToString(), "Number of characters", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Menu Open Plain text file
        private void plainTextToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFiledialog = new OpenFileDialog();
            openFiledialog.Filter = "Text Files|*.txt";
            if (openFiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string alphabet = File.ReadAllText(openFiledialog.FileName);
                textBoxPlaintext.Text = alphabet;
            }
        }

        //Meunu Open Cipher text file
        private void cipherTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFiledialog = new OpenFileDialog();
            openFiledialog.Filter = "Text Files|*.txt";
            if (openFiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ciphertext = File.ReadAllText(openFiledialog.FileName);
                textBoxCiphertext.Text = ciphertext;
            }
        }


        //Menu exit application
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonFreqPlain_Click(object sender, EventArgs e)
        {
            string input = textBoxPlaintext.Text.Trim();
            if (input == "")
                MessageBox.Show("Please fill data on plain text and key box", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    textBoxFreqPlain.Text = objCipher.Frequency(input);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonFreqCiph_Click(object sender, EventArgs e)
        {
            string input = textBoxCiphertext.Text.Trim();
            if (input == "")
                MessageBox.Show("Please fill data on plain text and key box", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    textBoxFreqCiph.Text = objCipher.Frequency(input);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonWordFreq_Click(object sender, EventArgs e)
        {
            string input = textBoxPlaintext.Text.Trim();
            if (input == "")
                MessageBox.Show("Please fill data on plain text and key box", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    textBoxFreqWord.Text = objCipher.WordFrequency(input);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
