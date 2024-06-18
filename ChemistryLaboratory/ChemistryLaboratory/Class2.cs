using System;

namespace MyApp.Class
{
    public class MaxLimitExceededException : Exception
    {
        public MaxLimitExceededException() : base("Reach the maximum limit. You can not add substances on the Stage.")
        {

        }
    }
    public class NoSubstancesException : Exception
    {
        public NoSubstancesException() : base("There are no substances on the Stage.")
        {

        }
    }
}
