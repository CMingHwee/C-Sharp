using System;

class ExceptionHandling {
  static void Main() {
    try {
      //prompt user for the first number and read input
      Console.Write("Input the first number: ");
      string input1 = Console.ReadLine();
      double number1 = Convert.ToDouble(input1);

      //prompt user for the second number and read input
      Console.Write("Input the second number: ");
      string input2 = Console.ReadLine();
      double number2 = Convert.ToDouble(input2);

      //check if the second number is not zero to avoid division by zero
      if (number2 != 0) {
        //calculate and display the result of division
        double result = number1 / number2;
        Console.WriteLine("Result: " + result);
      } else {
        //display error message if attempting to divide by zero
        Console.WriteLine("Error: Cannot divide by zero.");
      }
    } catch (FormatException) {
      //display error message for non-numeric input
      Console.WriteLine("Error: Non-numeric value entered.");
    } catch (Exception ex) {
      //display error message for handling other types of exceptions
      Console.WriteLine("An error occurred: " + ex.Message);
    }
  }
}
