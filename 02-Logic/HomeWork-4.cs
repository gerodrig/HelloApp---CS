partial class Program
{
    static void PrintMultiplicationTable(int number, int tableLimit = 10)
    {
        WriteLine($"Multiply table {number} from 1 to {tableLimit}\n");

        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number} x {i} = {number * i}");
        }
        WriteLine();

    }

    static void PrintFactorialTable(int number)
    {
        WriteLine($"Factorial for {number} from 1 to {number} \n");

        for (int i = 1; i <= number; i++)
        {
            WriteLine($"{i}! = {Factorial(i)}");
        }
        WriteLine();

    }

    static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
