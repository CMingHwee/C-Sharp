using System;
using System.Text.RegularExpressions;

namespace RemoveVowels
{
    class Vowel
    {
        static void Main(string[] args)
        {
            //declaring a string variable
            string text;

            //string containing only letters
            text = "Chicken";
            Console.WriteLine("Orginal string: " + text);
            Console.WriteLine("After removing vowels from the string: " + remove(text));

            //string containing letters and a space
            text = "Cat Dog";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("After removing vowels from the string: " + remove(text));

            //string containing only letters 
            text = "Elephant";
            Console.WriteLine("\nOrginal string: " + text);
            Console.WriteLine("After removing vowels from the string: " + remove(text));
        }

        public static string remove(string text)
        {
            //remove vowels (lowercase and uppercase) from the input string
            return new Regex(@"[aeiouAEIOU]").Replace(text, "");
        }
    }
}
