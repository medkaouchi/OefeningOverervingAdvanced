using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Bankrekening:Rekening
    {
        public Bankrekening(string rn,double s) : base(rn, s) { }
        public override double BerekenRente()
        {
            if (Saldo > 100)
                return Saldo /20;
            else
                return 0;
        }
    }
}
