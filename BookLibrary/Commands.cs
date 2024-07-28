namespace BookLibrary
{
    public static class Commands
    {

        public static List<Book> SearchForBooksByAuthor(List<Book> listOfBooks, string author)
        {
            return listOfBooks.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Book> SortedByPublicationYear(List<Book> listOfBooks)
        {
            return listOfBooks.OrderBy(book => book.PublicationYear).ToList();
        }

    }
}
