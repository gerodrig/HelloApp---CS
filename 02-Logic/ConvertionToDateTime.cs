using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");

        int friends = int.Parse("101");
        double cost = 35.45;
        DateTime birthday = DateTime.Parse("2 July 2025");
        WriteLine($"I have {friends} friends to invite to my party");
        WriteLine($"The celebration of my birthday will be {birthday}");
        WriteLine($"Long Format: {birthday:D}");
        WriteLine($"The cost of the entry will be {cost:C}");
    }
}
