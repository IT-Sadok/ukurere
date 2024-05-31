using System;

namespace MyApp.Class
{
    public class ChemistyLaboratory
    {
        private int maxSubstances;
        private int currentSubstancesCount;

        public ChemistyLaboratory(int max)
        {
            maxSubstances = max;
            currentSubstancesCount = 0;
        }

        public void ExecuteCommand(string command)
        {
            if (command == "add")
            {
                Add();
            }
            else if (command == "div")
            {
                Div();
            }
            else
            {
                Error();
            }
        }

        private void Add()
        {
            if (currentSubstancesCount < maxSubstances)
            {
                currentSubstancesCount++;
            }
            else
            {
                Console.WriteLine("Number of substances on the shelf is max.");
            }
        }

        private void Div()
        {
            if (currentSubstancesCount > 0)
            {
                currentSubstancesCount--;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void Error()
        {
            Console.WriteLine("Your command is incorrect.");
        }

        public int GetCurrentSubstancesCount()
        {
            return currentSubstancesCount;
        }
    }
}
