partial class Program
{
    static void DirectoryExample()
    {
        string baseDirectoryPath = "./05-Files/";

        Directory.CreateDirectory($"{baseDirectoryPath}DirExample/OtherDirectory");

        if (Directory.Exists($"{baseDirectoryPath}DirExample"))
        {
            WriteLine("The directory already exists");
        }

        //! Delete directory recursive is to delete all child directories
        Directory.Delete($"{baseDirectoryPath}DirExample", recursive: true);
    }
}
