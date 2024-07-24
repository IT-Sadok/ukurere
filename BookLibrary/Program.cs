using BookLibrary;

class Program
{
    static void Main()
    {
        string inputFilePath = "Library.json";
        string outputFilePath = "UpdatedLibrary.json";
        string command;

        try
        {
            List<Book> ListOfBooks = Read.LoadBooks(inputFilePath);

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
                        Commands.AddBook(ListOfBooks, Identifier, Title, Author, PublicationYear);
                        Console.WriteLine("Book is added. Everything is good!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error while adding book: " + e.Message);
                    }
                }
                else if (command == "2")
                {
                    int Identifier = int.Parse(Console.ReadLine());

                    try
                    {
                        Commands.RemoveBookByIdentifier(ListOfBooks, Identifier);
                        Console.WriteLine("Book is removed.");
                        Commands.DisplayBooks(ListOfBooks);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Book with the given Identifier not found: " + e.Message);
                    }
                }
                else if (command == "3")
                {
                    string Author = Console.ReadLine();

                    var FoundBooks = Commands.SearchForBooksByAuthor(ListOfBooks, Author);
                    Commands.DisplayBooks(FoundBooks);
                }
                else if (command == "4")
                {
                    var SortedBooks = Commands.SortedByPublicationYear(ListOfBooks);
                    Commands.DisplayBooks(SortedBooks);
                }
                else if (command == "5")
                {
                    Commands.SaveBooksToFile(ListOfBooks, outputFilePath);
                    Console.WriteLine("Data saved to file.");
                }
                else
                {
                    Console.WriteLine("Your command is incorrect. Please try again.");
                }
            }
        }
        catch (FileReadException fre)
        {
            Console.WriteLine(fre.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Something is wrong. Try again: " + e.Message);
        }
    }
}
using BookLibrary;

class Program
{
    static void Main()
    {
        string inputFilePath = "Library.json";
        string outputFilePath = "UpdatedLibrary.json";
        string command;

        try
        {
            List<Book> ListOfBooks = Read.LoadBooks(inputFilePath);

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
                        Commands.AddBook(ListOfBooks, Identifier, Title, Author, PublicationYear);
                        Console.WriteLine("Book is added. Everything is good!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error while adding book: " + e.Message);
                    }
                }
                else if (command == "2")
                {
                    int Identifier = int.Parse(Console.ReadLine());

                    try
                    {
                        Commands.RemoveBookByIdentifier(ListOfBooks, Identifier);
                        Console.WriteLine("Book is removed.");
                        Commands.DisplayBooks(ListOfBooks);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Book with the given Identifier not found: " + e.Message);
                    }
                }
                else if (command == "3")
                {
                    string Author = Console.ReadLine();

                    var FoundBooks = Commands.SearchForBooksByAuthor(ListOfBooks, Author);
                    Commands.DisplayBooks(FoundBooks);
                }
                else if (command == "4")
                {
                    var SortedBooks = Commands.SortedByPublicationYear(ListOfBooks);
                    Commands.DisplayBooks(SortedBooks);
                }
                else if (command == "5")
                {
                    Commands.SaveBooksToFile(ListOfBooks, outputFilePath);
                    Console.WriteLine("Data saved to file.");
                }
                else
                {
                    Console.WriteLine("Your command is incorrect. Please try again.");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Something is wrong. Try again: " + e.Message);
        }
    }
}
