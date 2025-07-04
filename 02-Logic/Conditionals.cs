partial class Program
{
    static void Conditionals()
    {
        int age = 19;
        if (age >= 18)
        {
            WriteLine("You are an adult");
        }
        else
        {
            WriteLine("You are underage");
        }

        //? if ternary
        string message = age >= 18 ? "You are an adult" : "You are underage";
        WriteLine(message);

        //? Multiple conditions
        int temperature = 30;
        if (temperature > 35)
        {
            WriteLine("It is too hot outside");
        }
        else if (temperature >= 20)
        {
            WriteLine("Temperature is enjoyable");
        }
        else
        {
            WriteLine("It is too cold outside");
        }

        //? Switch
        int day = 3;
        switch (day)
        {
            case 1:
                WriteLine("Monday");
                break;
            case 2:
                WriteLine("Tuesday");
                break;
            case 3:
                WriteLine("Wednesday");
                break;
            default:
                WriteLine("Invalid day");
                break;
        }

        //? Switch iwth expressions
        string messageDay = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            _ => "Invalid day"
        };
        WriteLine(messageDay);
    }
}
