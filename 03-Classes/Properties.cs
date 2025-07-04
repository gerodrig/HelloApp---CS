partial class Program
{
    static void Properties()
    {
        Animal animal = new("Forest");
        animal.Species = "Chinchilla";
        animal.Age = 7;
        WriteLine($"The {animal.Species} lives in the {animal.Habitat} and its {animal.Age} old");
    }

    class Animal(string habitat)
    {
        public string Species { get; set; } = "Unknown";
        public string Category { get; } = "Mammal";

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age cannot be negative.");
                }
                age = value;
            }
        }
        public string Habitat { get; } = habitat;
    }
}
