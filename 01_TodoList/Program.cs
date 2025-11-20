Console.WriteLine("Hello! What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

switch (userChoice)
{
    case "S":
    case "s":
        PrintSelectedOption("See all TODOs");
        Console.WriteLine("Another line");
        break;
    case "A":
    case "a":
        Console.WriteLine("Add a TODO");
        break;
    case "R":
    case "r":
        Console.WriteLine("Remove a TODO");
        break;
    case "E":
    case "e":
        Console.WriteLine("Exit");
        break;
    default:
        Console.WriteLine($"Invalid choice: {userChoice}");
        break;
}

void PrintSelectedOption(string selectedOption)
{
     Console.WriteLine($"Selected option: {selectedOption}");
}

Console.ReadKey();