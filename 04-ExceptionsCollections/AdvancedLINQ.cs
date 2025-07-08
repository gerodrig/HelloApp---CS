namespace AdvancedLinq
{
    class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }

    class Ability
    {
        public int CharacterId { get; set; }
        public string? Description { get; set; }
    }
    class Statistic
    {
        public int CharacterId { get; set; }
        public int Power { get; set; }
    }
    class Program
    {
        public static void AdvancedLINQ()
        {
            List<Character> characters =
            [
                new Character { Id = 1, Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
                new Character { Id = 2, Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
                new Character { Id = 3, Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
                new Character { Id = 4, Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
                new Character { Id = 5, Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
            ];

            List<Ability> abilities =
            [
                new Ability { CharacterId = 1, Description = "Spider sense" },
                new Ability { CharacterId = 1, Description = "Wall crawling" },
                new Ability { CharacterId = 2, Description = "Intelligence and high-tech armor" },
                new Ability { CharacterId = 3, Description = "Super strength" },
                new Ability { CharacterId = 4, Description = "Enhanced reflexes" },
                new Ability { CharacterId = 5, Description = "Magic and sorcery" }
            ];
            List<Statistic> statistics =
            [
                new Statistic { CharacterId = 1, Power = 85 },
                new Statistic { CharacterId = 2, Power = 90 },
                new Statistic { CharacterId = 3, Power = 88 },
                new Statistic { CharacterId = 4, Power = 80 },
                new Statistic { CharacterId = 5, Power = 95 }
            ];

            var teamsQuery = from c in characters
                             group c by c.Team into team
                             select team;

            var teamsMethod = characters.GroupBy(c => c.Team);

            foreach (var team in teamsQuery)
            {
                WriteLine($"👥 Team: {team.Key}");
                foreach (var character in team)
                {
                    WriteLine($" - {character.Name}");
                }


            }

            //? JOIN Collections
            var charactersWithAbilities = from c in characters
                                          join a in abilities on c.Id equals a.CharacterId
                                          select new { c.Alias, c.Name, a.Description };



            WriteLine("🦸‍♂️ Characters and their abilities:");
            foreach (var character in charactersWithAbilities)
            {
                WriteLine($"{character.Alias} {character.Name} - Ability: {character.Description}");
            }

            int totalPower = statistics.Sum(s => s.Power);
            WriteLine($"⚡ Total power of all characters: {totalPower}");

            var avengersPower = (from c in characters
                                 join s in statistics on c.Id equals s.CharacterId
                                 where c.Team == "Avengers"
                                 select s.Power).Average();

            WriteLine($"🛡️ Average power of the Avengers: {avengersPower:F2}");

            var abilitiesByCharacter = from c in characters
                                       join a in abilities on c.Id equals a.CharacterId
                                       group a by c.Alias into groupAbilities
                                       select new { Character = groupAbilities.Key, Count = groupAbilities.Count() };

            WriteLine("📝 Number of abilities per character:");
            foreach (var character in abilitiesByCharacter)
            {
                WriteLine($"{character.Character}: {character.Count} abilities");
            }
        }
    }
}