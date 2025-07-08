/*
=====================================
Sales Analysis with LINQ and Exceptions
=====================================
*/
// 🏆 Exercise:
// Develop a system to analyze a company's sales using collections and LINQ.
// You will have a "Sale" class with the following properties:
//  - Product (public)
//  - Category (public)
//  - Amount (public)
//
// Also, a list with 6 sample sales.
// What you need to develop is:
// 1. Filter and display sales with an amount greater than 1000.
// 2. Group sales by category and calculate the total sales per category.
// 3. Handle exceptions in case of errors while processing the data.

partial class Program
{
    static void SalesAnalysis()
    {

        try
        {
            List<Sale> sales =
            [
                new("Laptop", "Electronics", 1500),
                new ("Phone", "Electronics", 900),
                new ("Chair", "Furniture", 1200),
                new ("Desk", "Furniture", 800),
                new ("Tablet", "Electronics", 1300),
                new ("Lamp", "Lighting", 400)
            ];

            //? 1. Filter and display sales with an amount greater than 1000.
            WriteLine($"Sales with an amount greater than {1000:C}:");

            sales.Where(s => s.Amount > 1000)
                 .ToList()
                 .ForEach(s => WriteLine($"Product: {s.Product}, Category: {s.Category}, Price: {s.Amount:C}"));

            //? 2. Group sales by category and calculate the total sales per category.
            WriteLine($"Total sales by Category:");
            sales.GroupBy(s => s.Category).Select(g => new {Category = g.Key, TotalAmount = g.Sum(s => s.Amount)}).ToList().ForEach(p => WriteLine($"Category: {p.Category}, Total Sales: {p.TotalAmount:C}"));
            
        }
        catch (Exception ex)
        {
            WriteLine($"Error while processing sales: {ex.Message}");
        }
    }
}

class Sale(string product, string category, double amount)
{
    public string? Product { get; set; } = product;
    public string? Category { get; set; } = category;
    public double Amount { get; set; } = amount;
}