partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 999.99;
        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Sales Report:");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quantity Sold: {quantitySold}");
        Console.WriteLine($"Unit Price: {unitPrice:C}");
        Console.WriteLine($"Total Amount: {totalAmount:C}");
    }

    // 🏆 Exercise:
    // Create a program that calculates a worker's monthly salary
    // - Ask the user for their name, hours worked, and hourly rate
    // - Calculate the salary and display it on the screen

    static void SalaryCalculator()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to the Salary Calculator!");
        Console.ResetColor();
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "Unknown";

        Console.Write("Enter hours worked in a month: ");
        string? hoursInput = Console.ReadLine();
        int hoursWorked = int.Parse(hoursInput ?? "0");

        Console.Write("Enter your hourly rate: ");
        string? rateInput = Console.ReadLine();
        double hourlyRate = double.Parse(rateInput ?? "0");

        double monthlySalary = hoursWorked * hourlyRate;

        Console.WriteLine($"Hello {name}, your monthly salary is: {monthlySalary:C}");
    }
}