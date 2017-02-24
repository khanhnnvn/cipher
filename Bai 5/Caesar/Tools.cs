using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar
{
    class Tools
    {
        
        //Dictionary for function Charater Frequency. May be!
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

        //Character frequency
        public string Frequency(string text) 
        {
            StringBuilder textfrequency = new StringBuilder();
            Dictionary<char, long> freqs = letterFreqs(text);

            var items = from pair in freqs
                        orderby pair.Value descending
                        select pair;

            // Display results.
            foreach (KeyValuePair<char, long> pair in items)
            {
                textfrequency.Append(string.Format("Character '{0}' : {1}\n", pair.Key, pair.Value));
                textfrequency.Append(Environment.NewLine);
            }

            return textfrequency.ToString();
        }

        //Word frequency
        public string WordFrequency(string text) 
        {
            StringBuilder frequencyword = new StringBuilder();
            string textlower = text.ToLower();
            string[] stripChars = { ";", ",", ".", "-", "_", "^", "(", ")", "[", "]","0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n", "\t", "\r", "%", ":", "\"" };
            foreach (string character in stripChars)
            {
                textlower = textlower.Replace(character, "");
            }
            List<string> wordList = textlower.Split(' ').ToList();

            Dictionary<string, int> freqs = new Dictionary<string, int>();

            foreach (string word in wordList)
            {
                if (word.Length >= 1)
                {
                    if (freqs.ContainsKey(word))
                    {
                        freqs[word]++;
                    }
                    else
                    {
                        freqs[word] = 1;
                    }

                }
 
            }
            var items = from pair in freqs
                        orderby pair.Value descending
                        select pair;

            // Display results.
            foreach (KeyValuePair<string, int> pair in items)
            {
                frequencyword.Append(string.Format("Word '{0}' : {1} times", pair.Key, pair.Value));
                frequencyword.Append(Environment.NewLine);
            }
            return frequencyword.ToString();
        }
    }
}
