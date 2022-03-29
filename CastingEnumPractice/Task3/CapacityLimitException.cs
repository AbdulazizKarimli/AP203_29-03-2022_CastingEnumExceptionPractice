using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message)
        {
        }
    }
}
