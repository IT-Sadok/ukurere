namespace MyApp.Class
{
    public class NoSubstancesException : Exception
    {
        public NoSubstancesException() : base("There are no substances on the Stage.")
        {

        }
    }
}