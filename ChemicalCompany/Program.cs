using ChemicalCompany;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string inputFilePath = "ListOfSubstance.json";
        string command;

        try
        {
            string jsonString = File.ReadAllText(inputFilePath);

            List<Substance> listOfSubstance = JsonSerializer.Deserialize<List<Substance>>(jsonString) ?? new List<Substance>();

            while (true)
            {
                Console.WriteLine("Enter command (Add/Remove/Current):");
                command = Console.ReadLine();

                if (command == "Add")
                {
                    int ip = int.Parse(Console.ReadLine());
                    string nameOfSubstance = Console.ReadLine();
                    string typeInput = Console.ReadLine();

                    Substance.SubstanceType type;
                    if (!Enum.TryParse(typeInput, true, out type))
                    {
                        Console.WriteLine("Invalid type entered. Please try again.");
                        continue;
                    }

                    try
                    {
                        Options.Add(listOfSubstance, inputFilePath, new Substance(ip, nameOfSubstance, type));

                        Console.WriteLine("Substance added successfully.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error while adding substance.");
                    }
                }
                else if (command == "Remove")
                {
                    int ip = int.Parse(Console.ReadLine());

                    try
                    {
                        Options.Remove(listOfSubstance, inputFilePath, ip);

                        Console.WriteLine("Ok.");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Substance with the given IP not found.");
                    }
                }
                else if (command == "Current")
                {
                    Console.WriteLine(Options.Current(listOfSubstance));
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
