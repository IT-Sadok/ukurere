namespace BookLibrary
{
    public static class BookLogger
    {
        public static List<string> DisplayBooks(List<Book> books)
        {
            List<string> bookList = new List<string>();

            foreach (var book in books)
            {
                bookList.Add($"{book.Identifier}, {book.Title}, {book.Author}, {book.PublicationYear}");
            }

            return bookList;
        }
    }
}
