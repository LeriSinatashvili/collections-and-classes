using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColletionsAndClasses
{
    public class Person
    {
        private string name;
        public string Name { get; set; }

        private int age;
        public int Age 
        { 
            get 
            {
                if (age < 0)
                { return 0; }
                else if (age > 120)
                { return 120; }
                else
                { return age; };
            }
            set { age = value; } 
        }

        public string GetInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
