using System;

namespace FindPrime
{
    class Prime
    {
        static void Main(string[] args)
        {

            int n = 120; //initialize the varible to find the next prime number after
            Console.WriteLine("Original number: " + n);

            //display the next prime number after current value of n
            Console.WriteLine("Next prime number: " + next(n));

            //changing the value of n and finding next prime number again
            n = 321;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Next prime number: " + next(n));

            //changing the value of n and finding next prime number again
            n = 44;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Next prime number: " + next(n));

            //changing the value of n and finding next prime number again
            n = 4433;
            Console.WriteLine("\nOriginal number: " + n);
            Console.WriteLine("Next prime number: " + next(n));
        }

        //method to find the next prime number
        public static int next(int n)
        {
            for (int i = 2; i < n; i++)
            {
                //checking if n is divisible by i, if true, increment n and reset i to 2, if false, increment i and check again until a prime number is found
                if (n % i == 0) { 
                    n++;
                    i = 2;
                }
            }
            return n; //return the next prime number
        }
    }
}
