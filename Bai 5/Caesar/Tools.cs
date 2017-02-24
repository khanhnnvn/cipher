using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar
{
    class Tools
    {

        public string Character;
        public int CountCharater;


        protected char ShiftCharacter(char c, int shift)
        {
            shift = Math.Abs(shift);
            int characterIndex = Character.IndexOf(c);
            int shiftedIndex = (characterIndex + shift) % CountCharater;

            return Character[shiftedIndex];
        }

        protected char UnShiftCharacter(char c, int shift)
        {
            shift = Math.Abs(shift) % CountCharater;
            int characterIndex = Character.IndexOf(c);
            int tmpIndex = characterIndex - shift;
            int unshiftedIndex = (tmpIndex >= 0) ? tmpIndex : CountCharater + tmpIndex;

            return Character[unshiftedIndex];
        }

        public Dictionary<char, long> letterFreqs(string theText)
        {
            Dictionary<char, long> result = new Dictionary<char, long>();
            foreach (char c in theText)
            {
                if (result.ContainsKey(c))
                {
                    result[c]++;
                }
                else
                {
                    result[c] = 1;
                }
            }
            return result;
        }

    }
}
