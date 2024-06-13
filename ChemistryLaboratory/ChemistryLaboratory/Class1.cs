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
            if(currentSubstancesCount == maxSubstances)
            {
                throw new Exception("Reach the maximum limit. You can not add substances on the Stage. \n");
            }
            else
            {
                currentSubstancesCount++;
            }
        }

        public void Div()
        {
            if (currentSubstancesCount == 0)
            {
                throw new Exception("There are no substances on the Stage. \n");
            }
            else
            {
                currentSubstancesCount--;
            }
        }
}
