partial class Program {
    static void Operators()
    {
        int number = 15;

        bool isEven = number % 2 == 0;

        bool isGreaterThanTen = number > 10;

        if (isEven && isGreaterThanTen)
        {
            Console.WriteLine($"the number {number} is even and greater than 10.");
        }
        else if (!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"The number {number} is not even and is more than 10.");
        }
        else
        {
            Console.WriteLine($"The number {number} doesn't meet the criteria.");
        }

        int age = 15;
        string category = age > 18 ? "Adult" : "Underage";
        Console.WriteLine(category);
    }
}