using BookLibrary;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string inputFilePath = "Library.json";
        string command;

        try
        {
            string jsonString = File.ReadAllText(inputFilePath);

            List<Book> ListOfBooks = JsonSerializer.Deserialize<List<Book>>(jsonString) ?? new List<Book>();

            Console.WriteLine("You can do: \n1. Add a book\n2. Remove a book by identifier\n3. Search for books by author\n4. Display books sorted by publication year\n5. Save data to a file and load data from a file.\n");

            while (true)
            {
                Console.WriteLine("Select the option number you want to do:");

                command = Console.ReadLine();

                if (command == "1")
                {
                    int Identifier = int.Parse(Console.ReadLine());
                    string Title = Console.ReadLine();
                    string Author = Console.ReadLine();
                    int PublicationYear = int.Parse(Console.ReadLine());

                    try
                    {
                        Options.AddBook(ListOfBooks, Identifier, Title, Author, PublicationYear);

                        Console.WriteLine("Book is added. Everything is good!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error while adding book.");
                    }
                }
                else if (command == "2")
                {
                    int Identifier = int.Parse(Console.ReadLine());

                    try
                    {
                        Options.RemoveBookByIdentifier(ListOfBooks, Identifier);

                        Console.WriteLine("Book is removed.");
                        Options.DisplayBooks(ListOfBooks);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Book with the given Identifier not found.");
                    }
                }
                else if (command == "3")
                {
                    string Author = Console.ReadLine();

                    var FoundBooks = Options.SearchForBooksByAuthor(ListOfBooks, Author);
                    Options.DisplayBooks(FoundBooks);
                }
                else if (command == "4")
                {
                    var SortedBooks = Options.SortedByPublicationYear(ListOfBooks);
                    Options.DisplayBooks(SortedBooks);
                }
                else
                {
                    Console.WriteLine("Your command is incorrect. Please try again.");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Something is wrong. Try again.");
        }
    }
}
