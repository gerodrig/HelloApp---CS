partial class Program
{
    static void Collections()
    {
        List<string> names = ["Benito", "Mimi", "Emma"];
        names.Add("Yay");
        //ShowNames(names);
        // WriteLine("After removing Benito");
        names.Remove("Benito");
        //ShowNames(names);

        Dictionary<int, string> students = new()
        {
            {1, "Benito" },
            {2, "Mimi" },
            {3, "Emma" },
        };

        students.Add(4, "Gerardo");
        //ShowStudents(students);
        students.Remove(1);
        WriteLine("After removing Mimi");
        //ShowStudents(students);

        HashSet<string> users = ["Benito", "Mimi", "Emma"];
        users.Add("Yay");
        users.Add("Gerardo");
        users.Add("Poncho");

        foreach (var user in users)
        {
            WriteLine(user);
        }

    }

    private static void ShowStudents(Dictionary<int, string> students)
    {
        foreach (var student in students)
        {
            WriteLine($"Key: {student.Key}, Value: {student.Value}");
        }
    }

    private static void ShowNames(List<string> names)
    {
        names.ForEach(n => WriteLine(n));
    }
}
