using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirenTuin
{
    class Bij:Dier
    {
        public override int Gewicht { get { return base.Gewicht; } set =>base.Gewicht=value; }
        public Bij() { Gewicht = 1; }
        public override void Zegt()
        {
            Console.WriteLine("Een bij Zoemt");
        }
    }
}
