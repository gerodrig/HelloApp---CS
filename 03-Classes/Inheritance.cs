partial class Program
{
    static void Inheritance()
    {
        HogwartsStudent student = new() { Name = "Harry Potter", House = "Gryffindor" };
        HogwartsProfessor professor = new() { Name = "Severus Snape", Subject = "Potions" };

        student.Greet();
        student.ShowHouse();
        professor.Greet();
        professor.MySubject();
    }

    class Character
    {
        public string? Name { get; set; }
        public virtual void Greet()
        {
            WriteLine($"Hello, my name is {Name}");
        }
    }

    class HogwartsStudent : Character
    {
        public string? House { get; set; }
        public override void Greet()
        {
            WriteLine($"Hello, I am {Name} and I am a student.");
        }

        public void ShowHouse()
        {
            WriteLine($"I am part of {House} in Hogwarts.");
        }
    }

    class HogwartsProfessor : Character
    {
        public string? Subject { get; set; }
        public override void Greet()
        {
            WriteLine($"Hello, I am {Name} and I am a professor.");
        }

        public void MySubject()
        {
            WriteLine($"I teach {Subject} at Hogwarts.");
        }
    }
}
