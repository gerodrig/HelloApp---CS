using System.Globalization;

partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1985, 02, 18); // Replace with your actual birth date
        TimeSpan difference = DateTime.Now - birthDate;
        int daysLived = (int)difference.TotalDays;

        Console.WriteLine($"You have lived for {daysLived} days since your birth on {birthDate.ToString("dd/MM/yyyy")}.");
    }

    static void DaysUntilNextBirthday()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to the Days Until Birthday Calculator!");
        Console.ResetColor();

        Console.Write("Enter your birth date in the format (dd/MM/yyyy): ");
        DateTime birthday = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        DateTime currentDate = DateTime.Now.Date;

        DateTime nextBirthday = new DateTime(currentDate.Year, birthday.Month, birthday.Day);

        if (nextBirthday < currentDate)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        int daysRemaining = (nextBirthday - currentDate).Days;

        Console.WriteLine($"{daysRemaining} days remaining for your next birthday");
    }
}