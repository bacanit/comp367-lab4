using StringExtensionsLibrary;

class Program
{
    static void Main(string[] args)
    {
        string test1 = "Hello";
        string test2 = "hello";

        Console.WriteLine($"\"{test1}\" starts with uppercase: {test1.StartsWithUpper()}");
        Console.WriteLine($"\"{test2}\" starts with uppercase: {test2.StartsWithUpper()}");
    }
}