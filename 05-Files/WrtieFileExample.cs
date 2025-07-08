partial class Program
{
    static void WrtieFileExample()
    {
        string filePath = "./05-Files/WritingExample.txt";
        string content = "This will be added to the final path";
        StreamWriter streamWriter = new (filePath, append: true);
        streamWriter.WriteLine(content);
        streamWriter.WriteLine("Current time is: " + DateTime.Now.ToString("HH:mm:ss"));
        streamWriter.Dispose();

        WriteLine("File created successfully!");
        

    }
}
