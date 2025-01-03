using System.Text.Json;

namespace NetCore.Module.FileProcessing
{
    public static class JsonFile
    {
        public static T ReadFromJsonFile<T>(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            try
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
            catch (JsonException ex)
            {
                throw new JsonException($"Error deserializing JSON: {ex.Message}", ex);
            }
        }

        public static T ReadJsonFileBy<T>(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            try
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
            catch (JsonException ex)
            {
                throw new JsonException($"Error deserializing JSON: {ex.Message}", ex);
            }
        }
    }
}
