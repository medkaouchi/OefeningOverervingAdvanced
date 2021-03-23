using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirenTuin
{
    class Hond:Dier
    {
        public override int Gewicht { get { return base.Gewicht; } set => base.Gewicht = value; }

        public Hond() { Gewicht = 10000; }
        public override void Zegt()
        {
            Console.WriteLine("Een hond Blaft"); 
        }
    }
}
