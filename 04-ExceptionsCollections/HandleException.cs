partial class Program
{
    static string? amount;
    static void HandleException()
    {
        try
        {
            int number = 10;
            int result = number / 10;

            Write("Enter an amount: ");
            amount = ReadLine();

            if (string.IsNullOrEmpty(amount)) return;

            if (double.TryParse(amount, out double amountValue))
            {
                WriteLine($"The amount you entered is: {amountValue:C}");
            }
            else
            {
                WriteLine("Text couldn't be converted to number");
            }

            //double amountValue = double.Parse(amount);
            ValidateAge(16);
        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: numbers cannot be divided by zero");

        }
        catch (FormatException) when (amount?.Contains('$') == true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("There's no need to include $.");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine(ex.Message);
        }
        finally
        {
            Console.ResetColor();
            WriteLine("This Finally will alaways execute");
        }
    }

    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("The age must be over 18");
        }
    }
}
