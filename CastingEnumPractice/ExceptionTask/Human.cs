using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask
{
    internal class Human
    {
        private int _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age
        {
            get => _age; 
            set
            {
                if(value > 0)
                {
                    _age = value;
                    return;
                }

                throw new AgeException("yash 0 ve ya 0-dan kicikdir...");
            }
        }
    } 
}
