﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask
{
    internal class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }
}
