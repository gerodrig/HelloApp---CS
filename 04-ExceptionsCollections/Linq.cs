partial class Program
{
    static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumbers = [];

        numbers.ForEach(n => { if (n % 2 == 0) evenNumbers.Add(n); });

        //Query Syntax
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;

        //Method Syntax
        var evenNumbersMethod = numbers.Where(n => n % 2 == 0);

        foreach (var number in evenNumbersMethod)
        {
            WriteLine(number);
        }

        //Simple query
        List<MarvelCharacter> characters = [
    new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
    new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
    new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
    new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
    new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
    new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
    ];

        // WriteLine("Characters that are part of Avengers");
        var avengersQuery = from c in characters
                            where c.Team == "Avengers"
                            select $"{c.Alias} {c.Name}";

        var avengersMethod = characters.Where(c => c.Team == "Avengers");

        foreach (var character in avengersMethod)
        {
            WriteLine($"{character.Alias} {character.Name}");
        }

        var uppercaseNamesQuery = from c in characters
                                  select c.Name?.ToUpper();
        var uppercaseNamesMethod = characters.Select(c => c.Name?.ToUpper());

        // WriteLine("The Avengers names in Uppercase");
        // foreach (var name in uppercaseNamesMethod)
        // {
        //     WriteLine(name);
        // }

        var sortedQuery = from c in characters
                          orderby c.Name
                          select c.Name;

        var sortedMethod = characters.OrderByDescending(c => c.Name);

        // WriteLine("Order the names in descending order");
        // foreach (var name in sortedMethod)
        // {
        //     WriteLine(name);
        // }

        var firstThreeQuery = (from c in characters select c).Take(3);
        var firstThreeMethod = characters.Take(3);

        WriteLine("Getting the first 3 Avenger names");
        foreach (var character in firstThreeMethod)
        {
            WriteLine(character);
        }
    }
}

class MarvelCharacter
{
  public string? Name { get; set; }
  public string? Alias { get; set; }
  public string? Team { get; set; }
}