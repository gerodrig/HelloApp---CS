using System.Text.Json;
using TaskMaster;

namespace TaskMaster
{
    public class FileActions<T>(string name)
    {
        private readonly string filePath = name;
        private readonly JsonSerializerOptions _optionsWrite =
            new() { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
        private readonly JsonSerializerOptions _optionsRead =
            new() { PropertyNameCaseInsensitive = true };

        public void WriteFile(List<T> data)
        {
            try
            {
                string content = JsonSerializer.Serialize(data, _optionsWrite);

                StreamWriter sw = new(filePath);
                sw.Write(content);
                sw.Dispose();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Changes saved successfully!");
                Console.ResetColor();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
            catch (Exception ex)
            {
                Utils.CustomWrite($"An error occurred while writing to the file: {ex.Message}", Utils.MessageType.Success);
            }
        }

        public List<T> ReadFile()
        {
            try
            {
                StreamReader sr = new(filePath);
                string rawData = sr.ReadToEnd();
                List<T> data = JsonSerializer.Deserialize<List<T>>(rawData, _optionsRead)!;
                sr.Dispose();
                return data;
            }
            catch (IOException ex)
            {
                Utils.CustomWrite($"I/O error while reading the file: {ex.Message}", Utils.MessageType.Error);
                return [];
            }
            catch (Exception ex)
            {
                Utils.CustomWrite($"An error occurred while reading the file: {ex.Message}", Utils.MessageType.Error);
                return [];
            }
        }

    }


}

