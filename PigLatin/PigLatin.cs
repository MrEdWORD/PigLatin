using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatin
{
    public static class PigLatin
    {
        private static string[] Consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t",
                "v", "w", "x", "y", "z" };
        private static string ConsonantCluster = "group of consonants with no intervening vowel, " +
            "e.g. 'splits'...spl AND ts are clusters, but the i is a vowel.";
        private static string[] Vowels = { "a", "e", "i", "o", "u" };

        public static string ConvertToPigLatin(string input)
        {
            string output = string.Empty;
            string[] words = input.Split(null);
            List<string> pigLatinWords = new List<string>();

            foreach (string word in words)
            {
                string firstLetter = word.Substring(0, 1).ToLower();

                foreach (string s in Consonants)
                {
                    if (s == firstLetter)
                    {
                        string wordWithoutFirstLetter = word.Substring(1, word.Length - 1).ToLower();

                        pigLatinWords.Add(wordWithoutFirstLetter + firstLetter + "ay");
                    }
                }
            }
            output = String.Join(" ", pigLatinWords);
            return output;
        }
    }
}
