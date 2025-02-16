// var i = 0;
//
// while (i < 5)
// {
//     Console.WriteLine($"Counter is equal to {i}");
//     i++;
// }

// for (var i = 1; i <= 5; i++)
// {
//     Console.WriteLine($"Counter is equal to {i}");
// }

int number;
string userInput;

do
{
    Console.WriteLine("Please enter a number:");
    userInput = Console.ReadLine();
} while (!int.TryParse(userInput, out number));

Console.WriteLine(number);








// Console.WriteLine("Please enter a number:");
//
// string userInput = Console.ReadLine();
//
// if (int.TryParse(userInput, out int number))
// {
//     Console.WriteLine(number);
//     Console.WriteLine(number.GetType());
// }
// else
// {
//     Console.WriteLine("Sorry, we can't parse your input. Please try again.");
// }


// Console.WriteLine("Please enter a number:");
//
// string userInput = Console.ReadLine();
// int number = int.Parse(userInput);
//
// Console.WriteLine(number);
// Console.WriteLine(number.GetType());


// int x = 10;
// int y = 2;
//
// bool result = x % y == 0;
// string message = result ? $"{x} делится на {y} без остатка" : $"{x} не делится на {y} без остатка";
//
// Console.WriteLine(message);


// int x = 10;
// int y = 2;
//
// bool result = x % y == 0;
//
// if (result)
// {
//     Console.WriteLine($"{x} делится на {y} без остатка");
// }
// else
// {
//     Console.WriteLine($"{x} не делится на {y} без остатка");
// }