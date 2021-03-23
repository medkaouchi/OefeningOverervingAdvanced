using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class SpaarRekening:Rekening
    {
        public SpaarRekening(string rn, double s) : base(rn, s) { }
        public override double BerekenRente()
        {
                return Saldo /50;
        }
    }
}
