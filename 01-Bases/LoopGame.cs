partial class Program
{
    static void LoopGame()
    {
        int counter = 0;
        WriteLine("🎮 Press any key to increase the counter");
        WriteLine("🔴 Press ESC to exit.\n");

        while (true)
        {
            var key = ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                WriteLine($"You pressed {counter} keys before exiting");
                WriteLine("🟢Program ended");
                break;
            }
            counter++;
        }
    }
}
