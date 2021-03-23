using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOverervingAdvanced
{
    class CoffeeTableBook:Book
    {
        public override double Price
        {
            get { return base.Price; }
            set { if (value >= 35 && value <= 100) base.Price = value; else base.Price = -1; }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
