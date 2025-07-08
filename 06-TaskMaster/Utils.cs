using System.Net.WebSockets;

namespace TaskMaster
{
    public class Utils
    {
        public static string GeneratedId()
        {
            return Guid.NewGuid().ToString("N")[..7];
        }

        public static void CustomWrite(string text, MessageType type)
        {
            ConsoleColor color = type switch
            {
                MessageType.Success => ConsoleColor.Green,
                MessageType.Error => ConsoleColor.DarkRed,
                MessageType.Warning => ConsoleColor.Yellow,
                MessageType.Info => ConsoleColor.Cyan,
                _ => Console.ForegroundColor
            };

            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public enum MessageType
        {
            Success,
            Error,
            Warning,
            Info
        }
    }
}