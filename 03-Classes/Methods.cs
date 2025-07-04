partial class Program
{
    static void Methods()
    {
        Car car = new()
        {
            Model = "Chevy",
            Year = 2012
        };
        WriteLine(car.ShowInfo());

        // car.ShowMessage();
        // car.ShowMessage("Cambiando de modelo");
        // car.ChangeModel("Patrol");
        // WriteLine(car.ShowInfo());

        // Car.GeneralInfo();

        //? Object list
        WriteLine("List of cars: ");
        List<Car> cars = [new() { Model = "Duster", Year = 2021 }, new() { Model = "Stepway", Year = 2019 }, new() { Model = "Captur", Year = 2020 }];

        foreach (var vehicle in cars)
        {
            WriteLine(vehicle.ShowInfo());
        }
    }

    //? Constructor with parameters
    class Car(string model, int year)
    {
        public string? Model { get; set; } = model;
        public int? Year { get; set; } = year;
        public Car() : this(string.Empty, 0) { }
        ~Car()
        {
            WriteLine("Destructor called, Resource released.");
        }

        public void ChangeModel(string newModel)
        {
            Model = newModel;
        }
        public string ShowInfo()
        {
            return $"Vehicle: {Model}, Year: {Year}";
        }
        public void ShowMessage() => WriteLine("This is a vehicle");
        public void ShowMessage(string message) => WriteLine(message);

        public static void GeneralInformation()
        {
            WriteLine("The vehicle is the most popular way of transport");
        }
    }

    //Default constructor

    //?Destructor
}
