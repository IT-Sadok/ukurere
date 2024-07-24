using System.Text.Json;

namespace BookLibrary
{
    public static class Read
    {
        public static List<Book> LoadBooks(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Book>>(jsonString) ?? new List<Book>();
            }
            catch (Exception e)
            {
                throw new FileReadException($"Error reading the file: {e.Message}");
            }
        }
    }
}
