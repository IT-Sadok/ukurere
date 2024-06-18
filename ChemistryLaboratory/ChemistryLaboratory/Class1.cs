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
            if (currentSubstancesCount == maxSubstances)
            {
                throw new MaxLimitExceededException();
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
                throw new NoSubstancesException();
            }
            else
            {
                currentSubstancesCount--;
            }
        }
    }
}
