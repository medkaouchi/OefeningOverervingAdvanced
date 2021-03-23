using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class ProRekening:SpaarRekening
    {
        public ProRekening(string rn, double s) : base(rn, s) { }
        public override double BerekenRente()
        {
            return base.BerekenRente()+((Saldo/1000)*10);
        }
    }
}
