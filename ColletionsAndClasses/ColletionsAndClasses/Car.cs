using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColletionsAndClasses
{
    public class Car
    {
        private string brand;
        public string Brand { get; set; }

        private int year;
        public int Year
        {
            get
            {
                if (year < 1886)
                { return 1886; }
                else if (year > DateTime.Now.Year)
                { return DateTime.Now.Year; }
                else
                { return year; };
            }
            set { year = value; }
        }

        public string GetInfo()
        {
            return $"Brand: {Brand}, Year: {Year}";
        }
    }
}
