using System;


namespace MyApp.Class
{
    public class ChemistyLaboratory
    {
        public void Add(int maxSubstances, ref int currentSubstancesCount)
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

        public void Div(ref int currentSubstancesCount)
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
