


// Ask user for fave number

Console.WriteLine("Enter your favorite number: ");

// Turn that answer into an int

    /* Attempt 1, saves answer in a variable, implicit converstion fail

int variableName = Console.ReadLine();

    */

    /*Attempt 2, explicit converstion fails

int variableName = (int)value;

    */

    // Attempt 3, Built in method of conversion works
int faveNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wow your favorite number is " + faveNumber + ", so is mine!");



/*Here I am practicing using built in methods for mathmatical problems via code acadmey problems */


      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 

double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

      // Use built-in methods and save to variable 
      // number is negative so must convert to absolute value

double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
      // Print the lowest number
Console.WriteLine(Math.Min(numberTwoSqrt, numberOneSqrt));

/* other built in methods */
      
      
      double numberOne = 6.5;
      double numberTwo = 4;

      // Raise numberOne to the numberTwo power
      Console.WriteLine(Math.Pow(numberOne, numberTwo));

      // Round numberOne up
      Console.WriteLine(Math.Ceiling(numberOne));

      // Find the larger number between numberOne and numberTwo
      Console.WriteLine(Math.Max(numberOne, numberTwo));


