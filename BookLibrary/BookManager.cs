namespace BookLibrary
{
    public static class BookManager
    {
        public static void Add(List<Book> listOfBooks, int identifier, string title, string author, int publicationYear)
        {
            Book newBook = new Book
            {
                Identifier = identifier,
                Title = title,
                Author = author,
                PublicationYear = publicationYear
            };

            listOfBooks.Add(newBook);
        }

        public static void RemoveById(List<Book> listOfBooks, int identifier)
        {
            Book bookToRemove = listOfBooks.FirstOrDefault(book => book.Identifier == identifier);
            if (bookToRemove != null)
            {
                listOfBooks.Remove(bookToRemove);
            }
            else
            {
                throw new Exception("Book not found.");
            }
        }

        public static List<Book> SearchByAuthor(List<Book> listOfBooks, string author)
        {
            return listOfBooks.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Book> SortByPublicationDate(List<Book> listOfBooks)
        {
            return listOfBooks.OrderBy(book => book.PublicationYear).ToList();
        }
    }
}
