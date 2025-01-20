using System;

public class isPalindrome
{
    //function to check if a string is a palindrome
    public static bool checkPalindrome(string inputString)
    {
        //conert the input string into a character array
        char[] c = inputString.ToCharArray();

        //reverse the character array
        Array.Reverse(c);

        //check if the reversed string is equal to the original
        return new string(c).Equals(inputString);
    }

    public static void Main()
    {
        //test the checkPalindrome function with different input strings
        Console.WriteLine(checkPalindrome("racecar"));//True
        Console.WriteLine(checkPalindrome("abc"));    //False
        Console.WriteLine(checkPalindrome("madam"));  //True
        Console.WriteLine(checkPalindrome("1234"));   //False
    }
}
