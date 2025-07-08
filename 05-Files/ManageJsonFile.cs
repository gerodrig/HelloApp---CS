using System.Text.Json;

namespace ManageJsonFile
{
  class Character
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
  }
    partial class Program
    {
        private static readonly JsonSerializerOptions myJsonOptions = new() { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping};

        public static void ManageJsonFile()
        {
            List<Character> characters =
            [
            new Character { Id = 1, Name = "Peter Parker", Alias = "Spider", Team = "Avengers" },
            new Character { Id = 2, Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new Character { Id = 3, Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" }
            ];

            string characterJson = JsonSerializer.Serialize(characters, myJsonOptions);
            File.WriteAllText("./05-Files/characters.json", characterJson);

            var charactersFromFile = File.ReadAllText("./05-Files/characters.json");

            List<Character> charactersList = JsonSerializer.Deserialize<List<Character>>(charactersFromFile) ?? [];

            charactersList.ForEach(c => WriteLine($"Id: {c.Id}, name: {c.Name}, Alias: {c.Alias}, Team: {c.Team}"));
            
        }

  }
}