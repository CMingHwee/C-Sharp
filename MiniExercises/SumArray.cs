using System;

public class SumArray
{  
    public static void Main() 
    {
        //array with pre-defined values
        int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};

        //display the elements of the nums array using string.Join to concatenate them
        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));

        var sum = 0; //variable to accumulate the sum of the array 

        //iterate through the elements of the nums array using a for loop
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i]; //asd each element of the array to the sum variable
        }

        //display the sum of all elements in the array
        Console.WriteLine("Sum: " + sum);
    } 
}