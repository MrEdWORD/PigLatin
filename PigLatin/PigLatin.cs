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

            //Loop through the words from the input
            for (int wordNumber = 0; wordNumber < words.Length; wordNumber++)
            {
                char[] letters = words[wordNumber].ToLower().ToCharArray();
                int numberOfConsonants = 0;
                bool wordContainsConsonant = false;

                //Loop through the letters of a word
                for (int letterPosition = 0; letterPosition < letters.Length; letterPosition++)
                {
                    bool isVowel = IsLetterAVowel(letters, letterPosition);

                    if (letterPosition == 0 && !isVowel) //first letter is not a vowel
                    {
                        numberOfConsonants++;
                        wordContainsConsonant = true;
                    }
                    else if (letterPosition == 0 && isVowel) //first letter is a vowel
                    {
                        wordContainsConsonant = false;
                        break;
                    }
                    else if (wordContainsConsonant == true && !isVowel) //if first letter was consoannt and current letter is not a vowel
                    {
                        numberOfConsonants++;
                    }
                    else if (wordContainsConsonant == true && isVowel) //if first letter was consonant and current letter is vowel
                    {
                        break;
                    }
                }

                if (wordContainsConsonant == true)
                {
                    string consonants = words[wordNumber].ToLower().Substring(0, numberOfConsonants);
                    string restOfWord = words[wordNumber].ToLower().Substring(numberOfConsonants, (words[wordNumber].Length - numberOfConsonants));
                    pigLatinWords.Add(restOfWord + consonants + "ay");
                }
                else
                {
                    string restOfWord = words[wordNumber].ToLower();
                    pigLatinWords.Add(restOfWord + "ay");
                }

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