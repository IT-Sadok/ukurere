namespace BookLibrary
{
    public static class FileManager
    {
        public static void SaveBooksToFile(string filePath, List<Book> books)
        {
            try
            {
                string jsonString = System.Text.Json.JsonSerializer.Serialize(books);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception e)
            {
                throw new Exception($"Error saving books to file: {e.Message}");
            }
        }

        public static List<Book> LoadBooksFromFile(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                return System.Text.Json.JsonSerializer.Deserialize<List<Book>>(jsonString) ?? new List<Book>();
            }
            catch (Exception e)
            {
                throw new FileReadException($"Error loading books from file: {e.Message}");
            }
        }
    }
}
