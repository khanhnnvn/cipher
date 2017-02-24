using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar
{
    class CaesarCipher : Tools
    {
        //Function for Encrypt
        public string Encrypt(string plaintext, string character, int shift, int length)
        {
            char[] plain = plaintext.ToCharArray();
            char[] chartext = character.ToCharArray();

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < chartext.Length; j++)
                {
                    if (j <= chartext.Length - shift)
                    {
                        if (plain[i] == chartext[j])
                        {
                            plain[i] = chartext[j + shift];
                            break;
                        }
                    }
                    else if (plain[i] == chartext[j])
                    {
                        plain[i] = chartext[j - (chartext.Length - shift + 1)];
                    }
                }
            }
            return new string(plain);
        }

        //Function for Decrypt
        public string Decrypt(string crypttext, string character, int shift, int length)
        {
            char[] cipher = crypttext.ToCharArray();
            char[] chartext = character.ToCharArray();

            for (int i = 0; i < cipher.Length; i++)
            {
                for (int j = 0; j < chartext.Length; j++)
                {
                    if (j >= shift && cipher[i] == chartext[j])
                    {
                        cipher[i] = chartext[j - shift];
                        break;
                    }
                    if (cipher[i] == chartext[j] && j < shift)
                    {
                        cipher[i] = chartext[(chartext.Length - shift + 1) + j];
                        break;
                    }
                }
            }
            return new string(cipher);
        }
    }
}
