using System;
using System.Collections.Generic;
using System.Text;

namespace FootballDataWrapper.Business.Exceptions
{
    public class ConectivityException : Exception
    {
        public ConectivityException()
        {
        }

        public ConectivityException(string message)
            : base(message)
        {
        }

        public ConectivityException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
