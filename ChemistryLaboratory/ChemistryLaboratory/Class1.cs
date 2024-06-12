using System;

namespace MyApp.Class
{
    public class ChemistyLaboratory
    {
        public int maxSubstances;
        public int currentSubstancesCount;
        public string command;
        public bool MaxLimitReachedException = false, ImposibleLimitReached = false;
        public string Messenge;

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
            else
            {
                MaxLimitReachedException = true;
            }
        }

        public void Div()
        {
            if (currentSubstancesCount > 0)
            {
                currentSubstancesCount--;
            }
            else
            {
                ImposibleLimitReached = true;
            }
        }

        public string ChangeOnStage(string commad)
        {
            Messenge = "";
            MaxLimitReachedException = false;  
            ImposibleLimitReached = false;

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
                Messenge = "Your command is incorrect.";
            }

            if (MaxLimitReachedException)
            {
                Messenge = "Reach the maximum limit. You can not add substances on the Stage. \n";
            }
            else if (ImposibleLimitReached)
            {
                Messenge = "There are no substances on the Stage. ";
            }

            Messenge += ("Current number of substances: " + currentSubstancesCount);
            return Messenge;
        }

    }
}
