using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirenTuin
{
    class Kat:Dier
    {
        public override int Gewicht { get { return base.Gewicht; } set => base.Gewicht = value; }
        public Kat() { Gewicht = 5000; }
        public override void Zegt()
        {
            Console.WriteLine("Een kat Miauwt"); 
        }
    }
}
