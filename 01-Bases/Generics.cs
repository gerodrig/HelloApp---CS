partial class Program
{
    static void Generics()
    {
        string[] names = { "Benito", "Mimi", "Emma" };
        int[] numbers = { 1, 2, 3, 34 };
        WriteLine($"Size of the numeric array is: {GetArrayLength(numbers)}");
        WriteLine($"Size of the name array is: {GetArrayLength(names)}");

        Box<int> numberBox = new() { Content = 50 };
        Box<string> stringBox = new() { Content = "Now this is text" };
        numberBox.Show();
        stringBox.Show();
        
    }

    //Generic Method
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}

class Box<T>
{
    public T? Content { get; set; }

    public void Show()
    {
        WriteLine($"Content: {Content}");
    }
}
