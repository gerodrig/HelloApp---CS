partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 15;

        Console.WriteLine($"x:{x}, y:{y}");

        Person persona1 = new Person { Name = "Benito" };
        Person persona2 = persona1;

        persona2.Name = "Mimi";

        Console.WriteLine($"Persona 1 name is {persona1.Name} and Persona 2 name is {persona2.Name}");
    }
}

class Person
{ 
    public string? Name { get; set; }
}