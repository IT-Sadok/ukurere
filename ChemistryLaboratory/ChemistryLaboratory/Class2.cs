using System;

namespace MyApp.Class
{
    public class MaxLimitExceededException : Exception
    {
        public MaxLimitExceededException() : base("Reach the maximum limit. You can not add substances on the Stage.")
        {

        }
    }
}

