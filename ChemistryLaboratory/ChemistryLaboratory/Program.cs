using MyApp.Class;

Console.WriteLine("Please enter the maximum number of substances on the shelf:");
string input = Console.ReadLine();
int maxSubstances;

if (!int.TryParse(input, out maxSubstances))
{
    Console.WriteLine("Invalid number. Please restart the program and enter a valid number.");
}
ChemistyLaboratory lab = new ChemistyLaboratory(maxSubstances);

while (true)
{
    Console.WriteLine("Enter command (add/div):");

    lab.command = Console.ReadLine();

    Console.WriteLine(lab.ChangeOnStage(lab.command));
}
