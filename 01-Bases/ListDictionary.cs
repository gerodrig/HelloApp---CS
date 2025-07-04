partial class Program
{
    static void ListDictionary()
    {
        List<string> names = ["Mimi", "Benito", "Emma"];
        names.Add("Yay");
        WriteLine($"Total names: {names.Count}");

        foreach (var name in names)
        {
            WriteLine(name);
        }
        names.Remove("Emma");
        bool isPresent = names.Contains("Emma");
        WriteLine($"is Emma in the list? {isPresent}");

        //? Dictionary
        Dictionary<int, string> students = new() { { 1, "Mimi" }, { 2, "Benito" }, { 3, "Emma" } };

        WriteLine($"The student with ID 1 is {students[1]}");

        foreach (var student in students)
        {
            WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
        
    }
}