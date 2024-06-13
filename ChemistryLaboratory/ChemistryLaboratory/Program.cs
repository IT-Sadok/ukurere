using MyApp.Class;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the maximum number of substances on the shelf:");
            string input = Console.ReadLine();
            int maxSubstances;

            while (!int.TryParse(input, out maxSubstances))
            {
                Console.WriteLine("Invalid number. Please restart the program and enter a valid number.");
                input = Console.ReadLine();
            }

            ChemistyLaboratory lab = new ChemistyLaboratory(maxSubstances);

            while (true)
            {
                Console.WriteLine("Enter command (add/div):");

                lab.command = Console.ReadLine();

                if (lab.command == "add")
                {
                    try
                    {
                        lab.Add();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if (lab.command == "div")
                {
                    try
                    {
                        lab.Div();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Your command is incorrect.");
                }

                Console.WriteLine("Current number of substances: " + lab.currentSubstancesCount);
            }
        }
    }
}
