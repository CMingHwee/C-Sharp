using System;

namespace isPlural
{
    class Plural
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is 'Cat' plural? " + check("Cat"));

            Console.WriteLine("Is 'Cats' plural? " + check("Cats"));

            Console.WriteLine("Is 'Dogs' plural? " + check("Dogs"));

            Console.WriteLine("Is 'Dog' plural? " + check("Dog"));
        }

 
        public static bool check(string word)
        {
            //check if word ends with s
            return word.EndsWith("s");
        }
    }
}
