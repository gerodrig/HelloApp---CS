partial class Program
{
    static void FileExample()
    {
        string basePath = "./05-Files/";
        string filePath = "./05-Files/Example.txt";
        string content = File.ReadAllText(filePath);
        // WriteLine(content);

        string[] lines = File.ReadAllLines(filePath);

        lines.ToList().ForEach(line => WriteLine(line));

        //? Copy the file and overwrite if it exists
        File.Copy(filePath, basePath + "ExampleCopy.txt", overwrite: true);

        //! Delete a file
        File.Delete(basePath + "ExampleCopy.txt");
    }
}
