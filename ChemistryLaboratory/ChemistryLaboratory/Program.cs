using MyApp.Class;

Console.WriteLine("Please enter the maximum number of substances on the shelf:");
string input = Console.ReadLine();
int maxSubstances;
if (!int.TryParse(input, out maxSubstances))
{
    Console.WriteLine("Invalid number. Please restart the program and enter a valid number.");
    return;
}

ChemistyLaboratory lab = new ChemistyLaboratory(maxSubstances);

while (true)
{
    Console.WriteLine("Enter command (add/div):");
    string command = Console.ReadLine();
    lab.ExecuteCommand(command);
    Console.WriteLine("Current number of substances: " + lab.GetCurrentSubstancesCount());
}
