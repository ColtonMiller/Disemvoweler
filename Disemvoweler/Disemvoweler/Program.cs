using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls function Disemvoweler
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls");
            // keep the console open
            Console.ReadKey();
        }
        public static string Disemvoweler(string input)
        {
            //make lists for vowels and consonants
            List<char> vowels = new List<char>{};
            List<char> consonants = new List<char> {};
            //makes all character in input lowercase
            input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                //the character at i is a letter and is a vowel add to vowel list
                if ("aeiou".Contains(input[i]))
                {
                    vowels.Add(input[i]);
                }
                //the character at i is a letter but not a vowel add to consonant list
                else if ("BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz".Contains(input[i]))
                {
                    consonants.Add(input[i]);
                }
            }

            //turn lists to strings
            string vowelString = string.Join("", vowels);
            string consonantString = string.Join("", consonants);
            // Write out the various string results
            Console.WriteLine("Original: " + input );
            Console.WriteLine("Disemvoweled: " + consonantString );
            Console.WriteLine("Vowels Removed: " + vowelString ); 
            // Return the Disemvoweled string as well for testing
            return consonantString;
        }
    }
}
