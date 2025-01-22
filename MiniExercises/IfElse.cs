using System;

public class IfElse
{
    public static void Main()
    {
       
        int x, y;
        char operation;

        //input for the first number
        Console.Write("Input first number: ");
        x = Convert.ToInt32(Console.ReadLine());

        //input an operator (+, -, *, /)
        Console.Write("Input operator: ");
        operation = Convert.ToChar(Console.ReadLine());

        //input for the second number
        Console.Write("Input second number: ");
        y = Convert.ToInt32(Console.ReadLine());

        //arithmetic operation based on the operator entered
        if (operation == '+')
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        else if (operation == '-')
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        else if ((operation == 'x') || (operation == '*'))
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        else if (operation == '/')
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        else
            Console.WriteLine("Please enter a valid operator"); //display if an invalid operator is entered
    }
}
