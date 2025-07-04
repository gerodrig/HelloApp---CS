using System.Drawing;
using System.Security.Cryptography;

partial class Program
{
    static void DataStructures()
    {
        User mimi = new() { Name = "Mimi", Age = 6 };
        mimi.Greet();

        Point point = new() { X = 30, Y = 20 };
        WriteLine($"Point ({point.X},{point.Y})");
        CellPhone nokia = new("Nokia 225", 2025);
        WriteLine(nokia);

    }
}

class User
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        WriteLine($"Hello, I am {Name} and I am {Age} years old");
    }

}
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }

    record CellPhone(string Model, int Year);
