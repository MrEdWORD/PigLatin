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
        private static char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static string ConvertToPigLatin(string input)
        {
            string output = string.Empty;
            string[] words = input.Split(null);
            List<string> pigLatinWords = new List<string>();

            for (int wordNumber = 0; wordNumber < words.Length; wordNumber++)
            {
                char[] letters = words[wordNumber].ToLower().ToCharArray();
                int numberOfConsonants = 0;
                bool wordContainsConsonant = false;

                //this counts the number of elements in the word if starting with consonant
                for (int letterNumber = 0; letterNumber < letters.Length; letterNumber++)
                {
                    bool letterIsVowel = IsLetterAVowel(letters, letterNumber);

                    if (letterNumber == 0 && !letterIsVowel) //if first letter of word AND letter is not a vowel
                    {
                        numberOfConsonants++;
                        wordContainsConsonant = true;
                    }
                    else if (wordContainsConsonant == true && !letterIsVowel) //if first letter was consoannt and current letter is not a vowel
                    {
                        numberOfConsonants++;
                    }
                    else if (wordContainsConsonant == true && letterIsVowel) //if first letter was consonant and current letter is vowel
                    {
                        break;
                    }
                }
                string consonants = words[wordNumber].ToLower().Substring(0, numberOfConsonants);
                string restOfWord = words[wordNumber].ToLower().Substring(numberOfConsonants, (words[wordNumber].Length - numberOfConsonants));
                pigLatinWords.Add(restOfWord + consonants + "ay");
            }

            output = String.Join(" ", pigLatinWords);
            return output;
        }

        private static bool IsLetterAVowel(char[] letters, int letterNumber)
        {
            for (int i = 0; i < Vowels.Length; i++)
            {
                bool letterIsVowel = Vowels.Contains(letters[letterNumber]);

                if (letterIsVowel)
                {
                    return true;
                }
            }

            return false;
        }
    }
}