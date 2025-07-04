partial class Program
{
    static void TestingClass()
    {
        Vehicle toyota = new("Toyota", "Corolla", 2021);
        toyota.ShowInfo();

        Vehicle honda = new() { Brand = "Honda", Model = "Civic", Year = 2019 };
        honda.ShowInfo();

        Vehicle renault = new() { Brand = "Renault", Model = "Duster", Year = 2024 };
    }

    //? Constructor
    class Vehicle(string brand, string model, int year)
    {
        //? Properties
        public string? Brand { get; set; } = brand;
        public string? Model { get; set; } = model;
        public int Year { get; set; } = year;

        public Vehicle() : this(string.Empty, string.Empty, 0) { }

        //? Methods
        public void ShowInfo()
        {
            WriteLine($"This vehicle {Brand} {Model} year {Year}");
        }



    }
}
