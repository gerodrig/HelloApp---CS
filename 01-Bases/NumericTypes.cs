

partial class Program
{
    static void ShowNumericTypes()
    {
        int integer = int.MaxValue;
        double floatingPoint = double.MaxValue;
        float singlePrecision = 2.718f;
        long largeNumber = 123_456_789L;
        decimal preciseNumber = 19.99m;
    
        Console.WriteLine($"Integer: {integer}, Floating Point: {floatingPoint}, Single Precision: {singlePrecision}, Large Number: {largeNumber}, Precise Number: {preciseNumber}");
    }
}