using System;
using System.Collections.Generic;

namespace C__test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter up to 256 characters: ");
            string user_input = Console.ReadLine(); // Readline only excepts 254 characters with 2 characters reserved for CR and LF
            user_input = user_input.ToLower();

            string not_used = LettersNotUsed(user_input);
            string used_count = UsedLetterCount(user_input);

            Console.WriteLine("Unused letters: " + not_used);
            Console.WriteLine("Used letter counts:\n" + used_count);
        }

        static string LettersNotUsed(string input)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach(var letter in input)
            {
                if(alphabet.Contains(letter))
                {
                    alphabet = alphabet.Replace(letter.ToString(), String.Empty);
                }
            }

            return alphabet;
        }
        
        static string UsedLetterCount(string input)
        {
            Dictionary<string, int> used_letters = new Dictionary<string, int>();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach(var letter in input)
            {
                if(used_letters.ContainsKey(letter.ToString()))
                {
                    used_letters[letter.ToString()] = used_letters[letter.ToString()] + 1;
                }
                else if (alphabet.Contains(letter))
                {
                    used_letters.Add(letter.ToString(), 1);
                }
            }

            string output = "";
            foreach(var letter in used_letters)
            {
                output = output + letter.Key + ": " + letter.Value + "\n";
            }

            return output;
        }
    }
}
