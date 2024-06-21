using ChemicalCompany;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string inputFilePath = "ListOfSubstance.json";

        try
        {
            string jsonString = File.ReadAllText(inputFilePath);

            List<Substance> listOfSubstance = JsonSerializer.Deserialize<List<Substance>>(jsonString);

            listOfSubstance.Add(new Substance(123, "H2O", Substance.SubstanceType.Base));

        }
        catch (Exception e)
        {
            Console.WriteLine("Something is wrong. Correct errors and try again.");
        }
    }
}
