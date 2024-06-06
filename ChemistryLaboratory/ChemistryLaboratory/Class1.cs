using System;

namespace MyApp.Class
{
    public class ChemistyLaboratory
    {
        public int maxSubstances;
        public int currentSubstancesCount;
        public string command;

        public ChemistyLaboratory(int max)
        {
            maxSubstances = max;
            currentSubstancesCount = 0;
        }

        public void Add()
        {
            if (currentSubstancesCount < maxSubstances)
            {
                currentSubstancesCount++;
            }
        }

        public void Div()
        {
            if (currentSubstancesCount > 0)
            {
                currentSubstancesCount--;
            }

        }

        public string ChangeOnStage(string commad)
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
                return ("Your command is incorrect.");
            }
            return ("Current number of substances: " + currentSubstancesCount);
        }

    }
}
