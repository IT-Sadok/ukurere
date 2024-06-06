using System;

namespace MyApp.Class
{
    public class ChemistyLaboratory
    {
        private int maxSubstances;
        public int currentSubstancesCount;

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
    }
}
