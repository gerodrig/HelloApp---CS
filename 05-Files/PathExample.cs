partial class Program
{
    static void PathExample()
    {
        string filePath = "./05-Files/Example.txt";
        string fileName = Path.GetFileName(filePath);
        WriteLine($"Filename is: {fileName}");

        string fileExtension = Path.GetExtension(filePath);
        WriteLine($"File extension is: {fileExtension}");

        string? directoryName = Path.GetDirectoryName(filePath);
        WriteLine($"Directory name is: {directoryName}");

        string combinedPath = Path.Combine("C:", "User", "Documents", "Example.txt");
        WriteLine($"Combined route path is: {combinedPath}");

        string fullFilePath = Path.GetFullPath(filePath);
        WriteLine($"Full file path is: {fullFilePath}");
    }
}
