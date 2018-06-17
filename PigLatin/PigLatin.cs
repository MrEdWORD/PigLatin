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
        public static string[] Consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t",
                "v", "w", "x", "y", "z" };
        private static string ConsonantCluster = "group of consonants with no intervening vowel, " +
            "e.g. 'splits'...spl AND ts are clusters, but the i is a vowel.";
        private static string[] Vowels = { "a", "e", "i", "o", "u" };

        public static string ConvertToPigLatin(string input)
        {
            string output = string.Empty;
            string firstLetterOfInput = input.Substring(0, 1).ToLower();

            foreach (string s in Consonants)
            {
                if (firstLetterOfInput == s)
                {
                    string inputWithoutConsonant = input.Substring(1, input.Length - 1).ToLower();
                    output = inputWithoutConsonant + firstLetterOfInput + "ay";
                }
            }

            return output;
        }
    }
}
