partial class Program
{
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    static string EvaluateNumber(int number)
    {
        if (number > 0)
        {
            return "Positive";
        }
        else if (number < 0)
        {
            return "Negative";
        }
        else
        {
            return "Zero";
        }
    }
    static void Functions()
    {
        var area = CalculateArea(4.5, 2.23);
        WriteLine($"The area is: {area}");
        var evaluatedNumber = EvaluateNumber(-45);
        WriteLine($"The number evaluated is: {evaluatedNumber}");
    }
}
