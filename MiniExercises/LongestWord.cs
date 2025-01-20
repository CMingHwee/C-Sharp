using System;  

public class LongestWord
{  
    public static void Main() 
    {          
        string line = "What is the longest word here?";

        //split the string into words based on spaces and storing them in an array
        string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

        string word = ""; //empty string to store the longest word
        int counter = 0; //counter to keep track of the longest word

        //looping through each word in the words array
        foreach (String s in words)
        {
            //checking if the length of the current word is greater than the stored longest word
            if (s.Length > counter)
            {
                word = s; //if the current word's length is greater, update the word variable
                counter = s.Length; //update the longest word counter
            }
        }

        Console.WriteLine(word); // display the longest word
    }
}
