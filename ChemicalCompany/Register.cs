namespace ChemicalCompany
{
    public class Substance
    {
        public int Ip { get; set; }
        public string NameOfSubstance { get; set; }
        public SubstanceType Type { get; set; }

        public enum SubstanceType
        {
            Acid,
            Base,
            Oxide,
            Salt
        }

        public Substance(int ip, string nameOfSubstance, SubstanceType type)
        {
            Ip = ip;
            NameOfSubstance = nameOfSubstance;
            Type = type;
        }
    }
}
