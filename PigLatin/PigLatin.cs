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
        private static char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static string ConvertToPigLatin(string input)
        {
            string output = string.Empty;
            string[] words = input.Split(null);
            List<string> pigLatinWords = new List<string>();

            foreach (string word in words)
            {
                string firstLetter = word.Substring(0, 1).ToLower();
                string restOfWord = word.Substring(1, (word.Length - 1)).ToLower();

                foreach (char vowel in Vowels)
                {
                    if (firstLetter != vowel.ToString())
                    {
                        pigLatinWords.Add(restOfWord + firstLetter + "ay");
                        break;
                    }
                }
            }
            output = String.Join(" ", pigLatinWords);
            return output;
        }

        public static string ConvertToPigLatinCluster(string input)
        {
            string output = string.Empty;
            string[] words = input.Split(null);
            List<string> pigLatinWords = new List<string>();

            int loopCounter = 0;
            foreach (string word in words)
            {

                char[] lettersArr = words[loopCounter].ToLower().ToCharArray();
                int consonantCounter = 0;
                bool wordStartsWithConsonant = false;

                //this counts the number of elements in the word if starting with consonant
                for (int i = 0; i < lettersArr.Length; i++)
                {
                    int j = Array.IndexOf(Vowels, lettersArr[i]);

                    if (i == 0 && j == -1) //if first letter of word AND letter is not a vowel
                    {
                        consonantCounter++;
                        wordStartsWithConsonant = true;
                    }
                    else if (wordStartsWithConsonant == true && j == -1) //if first letter was consoannt and current letter is not a vowel
                    {
                        consonantCounter++;
                    }
                    else if (wordStartsWithConsonant == true && j != -1) //if first letter was consonant and current letter is vowel
                    {
                        break;
                    }
                }
                string firstConsonants = words[loopCounter].ToLower().Substring(0, consonantCounter);
                string restOfWord = words[loopCounter].ToLower().Substring(consonantCounter, (words[loopCounter].Length - consonantCounter));
                pigLatinWords.Add(restOfWord + firstConsonants + "ay");
                loopCounter++;
            }

            output = String.Join(" ", pigLatinWords);
            return output;
        }

        private static void DoTheWordPlusYayThing()
        {
            throw new NotImplementedException();
        }
    }
}
