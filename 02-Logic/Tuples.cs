partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (42, "Hello");
        WriteLine($"Number: {myTuple.Item1}, Text: {myTuple.Item2}");

        (int Number, string Text) myOtherTuple = (33, "Named");
        WriteLine($"Number: {myOtherTuple.Number}, Text: {myOtherTuple.Text}");

        var operations = Operations(20, 10);
        WriteLine($"Sum: {operations.Sum}, Subtraction: {operations.Subtraction}");

        (int sum, int Subtraction) = Operations(25, 15);
        WriteLine($"Sum: {sum}, Subtraction: {Subtraction}");
    }

    static (int Sum, int Subtraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}
