using System.Data;
using System.Text.Json;

namespace ChemicalCompany
{
    public static class Options
    {
        public static void Add(List<Substance> listOfSubstance, string filePath, Substance newSubstance)
        {
                listOfSubstance.Add(newSubstance);

                string jsonString = JsonSerializer.Serialize(listOfSubstance, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            
        }

        public static void Remove(List<Substance> listOfSubstance, string filePath, int ip)
        {
            Substance substanceToRemove = listOfSubstance.Find(s => s.Ip == ip);

            if (substanceToRemove != null)
            {
                listOfSubstance.Remove(substanceToRemove);

                string jsonString = JsonSerializer.Serialize(listOfSubstance, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            }
            else
            {
                throw new Exception(); 
            }            
        }

        public static int Current(List<Substance> listOfSubstance)
        {
            return listOfSubstance.Count;
        }
    }
}
