partial class Program
{
    //? NOt nullable
    static void HandleNullables()
    {
        string firstName = "Benito";

        //? Nullable
        string? lastName = null;

        Console.WriteLine($"Name: {firstName}");

        // if (lastName != null)
        // {
        //     Console.WriteLine($"Lastname: {lastName}");
        // }
        // else
        // {
        //     Console.WriteLine("LastName was not provided");
        // }
        //? Coallescent operator
        Console.WriteLine($"Lastname: {lastName ?? "LastName was not specified"}");

        string? text = null;

        Console.WriteLine(text?.Length);
        Console.WriteLine("Continuing executing");
    }
}