

partial class Program
{
    static void ShowStringTypes()
    {
        string name = "Benito";
        string message = "Hello " + name + ", welcome to the program!";
        string interPolatedMessage = $"Hello {name}, welcome to the program!";

        Console.WriteLine(message);
        Console.WriteLine($"String Concatenation: {message}");
        Console.WriteLine($"Your name has {name.Length} characters.");
        Console.WriteLine($"Your name in uppercase: {name.ToUpper()}");
        Console.WriteLine($"Your name in lowercase: {name.ToLower()}");

        int number = 42;
        Console.WriteLine(number.ToString());
        bool isString = true;
        Console.WriteLine(isString.ToString());
        
    }
}