namespace _01_Calculator; 

public class Calculator
{
    public static int Main()
    {

        Console.WriteLine("Hello!");

        int firstNumber;
        int secondNumber;

        while (true)
        {
            Console.WriteLine("Input the first number:");
            var line = Console.ReadLine();
            if (int.TryParse(line, out firstNumber))
                break;

            Console.WriteLine("Invalid number. Please enter a valid number.");
        }

        while (true)
        {
            Console.WriteLine("Input the second number:");
            var line = Console.ReadLine();
            if (int.TryParse(line, out secondNumber))
                break;

            Console.WriteLine("Invalid number. Please enter a valid number.");
        }


        Console.WriteLine("What do you want to do?\n [A]dd numbers\n [S]ubtract numbers\n [M]ultiply numbers");
        var userChoice = Console.ReadLine()!.ToUpper();

        switch (userChoice)
        {
            case "A":
                Console.WriteLine($"The result is: {firstNumber + secondNumber}"); // -> "$" is used for string interpolation, when we insert variables inside a string
                break;
            case "S":
                Console.WriteLine($"The result is: {firstNumber - secondNumber}");
                break;
            case "M":
            // Console.WriteLine($"The result is: {firstNumber * secondNumber}");
            // break;
            // validate if the second number is zero
            default:
                Console.WriteLine("Invalid option selected.");
                break;
        }

        return 0;
    }
}