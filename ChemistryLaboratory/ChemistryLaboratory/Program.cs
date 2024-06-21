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
            string command;
            int currentSubstancesCount = 0;

            while (!int.TryParse(input, out maxSubstances))
            {
                Console.WriteLine("Invalid number. Please enter a valid number.");
                input = Console.ReadLine();
            }

            ChemistyLaboratory lab = new ChemistyLaboratory();

            while (true)
            {
                Console.WriteLine("Enter command (add/div):");

                command = Console.ReadLine();

                try
                {
                    if (command == "add")
                    {
                        lab.Add(maxSubstances, ref currentSubstancesCount);
                    }
                    else if (command == "div")
                    {
                        lab.Div(ref currentSubstancesCount);
                    }
                    else
                    {
                        throw new Exception("Your command is incorrect. Try again.");
                    }
                }
                catch (MaxLimitExceededException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (NoSubstancesException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Current number of substances: " + currentSubstancesCount);
            }
        }
    }
}
