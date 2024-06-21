using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChemicalCompany
{
    public class Substance
    {
        public int Ip { get; set; }
        public string NameOfSubstance { get; set; }

        public enum SubstanceType
        {
            Acid,
            Base,
            Oxide,
            Salt
        }

        public Substance (int Ip, string NameOfSubstance, Enum SubstanceType)
        {
            Ip = Ip;
            NameOfSubstance = NameOfSubstance;
            SubstanceType = SubstanceType;
        }
    }
}
