using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirenTuin
{
    class Schaap:Dier
    {
        public override int Gewicht { get { return base.Gewicht; } set => base.Gewicht= value; }
        public Schaap() { Gewicht = 50000; }
        public override void Zegt()
        {
            Console.WriteLine("Een schaap Blaat");
        }
    }
}
