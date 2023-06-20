


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




