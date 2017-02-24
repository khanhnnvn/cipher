using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar
{
    class CaesarCipher : Tools
    {
        public string Encrypt(string input, string shift)
        {
            int shiftNumber = int.Parse(shift);
            StringBuilder ciphered = new StringBuilder(input.Length);

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    ciphered.Append(ShiftCharacter(c, shiftNumber));
                }
                else
                {
                    ciphered.Append(c);
                }
            }

            return ciphered.ToString();
        }


        public string Decrypt(string input, string shift)
        {
            int shiftNumber = int.Parse(shift);
            StringBuilder deciphered = new StringBuilder(input.Length);

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    deciphered.Append(UnShiftCharacter(c, shiftNumber));
                }
                else
                {
                    deciphered.Append(c);
                }
            }

            return deciphered.ToString();
        }
    }
}
