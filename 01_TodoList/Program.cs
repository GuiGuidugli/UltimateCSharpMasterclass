Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

bool IsLong(string input)
{
    return input.Length > 10;
}

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine($"Selected option: {selectedOption}");
}

var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice);

switch (userChoice)
{
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine($"Invalid choice: {userChoice}");
        break;
}

Console.ReadKey();