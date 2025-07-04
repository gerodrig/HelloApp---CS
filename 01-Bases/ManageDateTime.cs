partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime nowWeekAgo = now.AddDays(-7);
        DateTime customDate = new DateTime(1985, 02, 18);

        DayOfWeek dayOfWeek = now.DayOfWeek;

        Console.WriteLine($"Current Date and Time: {now}");
        Console.WriteLine($"Today's Date: {today}");
        Console.WriteLine($"Date and Time a Week Ago: {nowWeekAgo.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Custom Date: {customDate}");
        Console.WriteLine($"Day of the Week: {dayOfWeek}");
    }
}