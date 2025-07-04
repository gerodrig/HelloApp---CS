partial class Program
{
    static void Loops()
    {
        //? While
        int counter = 1;
        while (counter <= 5)
        {
            // WriteLine($"iteration: {counter}");
            counter++;
        }

        //? Do while
        int number = 0;
        do
        {
            // WriteLine($"Number: {number}");
            number++;
        } while (number < 3);

        for (int i = 0; i <= 5; i++)
        {
            WriteLine($"Iteration: {i}");
        }
        // Personalizando el for
        for (int i = 10; i >= 0; i -= 2)
        {
            WriteLine(i);
        }
        //foreach
        // Array
        string[] fruits = ["Apple", "Pear", "Pineapple"];
        foreach (var fruit in fruits)
        {
            WriteLine(fruit);
        }
        // List
        List<string> names = ["Benito", "Mimi", "Emma"];
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }
}
