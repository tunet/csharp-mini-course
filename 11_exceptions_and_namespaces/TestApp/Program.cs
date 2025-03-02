using TestApp;
using TestApp.Animals;
using TestApp.Exceptions;

var list = new CustomList<Cat>();

try
{
    list.Add(new Cat { Name = "Fluffy" });
    list.Add(new Cat { Name = "Whiskers" });
    list.Add(new Cat { Name = "Socks" });
    list.Add(new Cat { Name = "Mittens" });

    Console.WriteLine("Test...");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Huston, we have a problem: {ex.Message}");
}
catch (FullListException ex)
{
    Console.WriteLine($"FullListException happened: {ex.Message}");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"We catch an exception: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Base exception: {ex.Message}");
}
