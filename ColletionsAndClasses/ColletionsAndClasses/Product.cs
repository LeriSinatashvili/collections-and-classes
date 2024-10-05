using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ColletionsAndClasses
{

    enum Currency
    {

        GEL,
        USD,
        EUR

    }

    internal class Product
    {
        private string name;
        public string Name { get; set; }

        private decimal price;
        public decimal Price
        {
            get
            {
                if (price < 0)
                { return 0; }
                else
                { return price; };
            }
            set { price = value; }
        }

        public Currency Currency { get; set; }


        public string GetInfo()
        {
            return $"Name: {Price}, Price: {Name}, Currency: {Currency}";
        }

    }

}
