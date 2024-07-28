namespace BookLibrary
{
    public static class BookLogger
    {
        public static void DisplayBooks(List<Book> books)
        {
            List<string> bookList = new List<string>();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Identifier}, {book.Title}, {book.Author}, {book.PublicationYear}");
            }
        }
    }
}
