partial class Program
{
    static void AbstracClassExamples()
    {
        HomeAppliance myWasher = new WashingMachine { Brand = "Samsung" };
        HomeAppliance myMicrowave = new Microwave { Brand = "LG" };
        myWasher.ShowBrand();
        myWasher.TurnOn();
        myMicrowave.ShowBrand();
        myMicrowave.TurnOn();
    }

    abstract class HomeAppliance
    {
        public string? Brand { get; set; }
        public abstract void TurnOn();

        public void ShowBrand()
        {
            WriteLine($"The brand of the applinace is {Brand}");
        }
    }

    class WashingMachine : HomeAppliance
    {
        public override void TurnOn()
        {
            WriteLine("🌀 The washer has started with the washing cycle.");
        }

    }

    class Microwave : HomeAppliance
    {
           public override void TurnOn()
        {
            WriteLine("🔥 The microwave has started heating the food.");
        }

    }
}
