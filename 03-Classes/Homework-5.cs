/*
=============
🏆 Exercise 
=============
*/
// 1. Create a class "Bus" with the following properties:
//    - Brand (public)
//    - Model (public)
//    - Year (public)
//    - Price (public)
//    - TotalKilometers (public)
//
// 2. Implement a constructor to initialize the values.
// 3. Add a method "Drive(int kilometers)" that increases the mileage.
// 5. Add a method "ShowPrice()" that returns the price of the bus.
// 6. Create a class "Fleet" that manages a list of buses.
//    - Method to add buses to the fleet.
//    - Method to display the list of buses.
//
// 7. Instantiate at least three objects of the Bus class, add them to the Fleet, and simulate driving 5000.
// 8. Show the details of the fleet before and after driving.
partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new();
        Product laptop = new("Laptop", 1200.99, 5);
        Product mouse = new("Mouse", 100, 10);
        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);
        // inventory.ShowInventory();
        // laptop.Sell(1);
        // inventory.ShowInventory();
    
    }
    static void BusFleet()
    {
        Bus corollaBus = new("Toyota", "Corolla", 2020, 30_000, 10_000);
        Bus hondaBus = new("Honda", "Civic", 2019, 20_000, 8_000);
        Bus fordBus = new("Ford", "Fiesta", 2018, 25_000, 9_000);

        Fleet fleet = new();
        fleet.AddBus(corollaBus);
        fleet.AddBus(hondaBus);
        fleet.AddBus(fordBus);

        fleet.ShowBuses();
        corollaBus.Drive(5000);
        hondaBus.Drive(5000);
        fordBus.Drive(5000);
        fleet.ShowBuses();
    
    }

    class Product(string name, double price, int stock)
    {
        public string? Name { get; set; } = name;
        public double Price { get; set; } = price;
        public int Stock { get; set; } = stock;

        public void ShowInfo()
        {
            WriteLine($"Producto: {Name}, Precio: {Price}, Stock:{Stock}");
        }
        public bool Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock -= quantity;
                WriteLine($"Sale: {quantity} units of {Name} ");
                return true;
            }
            WriteLine($"Not enough stock for {Name}");
            return false;
        }
    }

    class Inventory
    {
        private List<Product> products = [];

        public void AddProduct(Product product) => products.Add(product);

        public void ShowInventory() => products.ForEach(p => p.ShowInfo());
                
    }

    class Bus(string brand, string model, int year, double price, int totalKilometers)
    {
        public string Brand { get; set; } = brand;
        public string Model { get; set; } = model;
        public int Year { get; set; } = year;
        public double Price { get; set; } = price;
        public int TotalKilometers { get; set; } = totalKilometers;

        public void Drive(int kilometers)
        {
            TotalKilometers += kilometers;
        }

        public void ShowPrice() => WriteLine($"Price{Price}:C");
    
    }

    class Fleet
    {
        private List<Bus> buses = [];

        public void AddBus(Bus bus) => buses.Add(bus);

        public void ShowBuses() => buses.ForEach(bus => WriteLine($"Marca: {bus.Brand}, Modelo {bus.Model}, Año: {bus.Year}, Kilometraje: {bus.TotalKilometers}"));

    
  }
}