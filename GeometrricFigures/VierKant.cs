using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrricFigures
{
    class VierKant:RechtHoek
    {
        public VierKant(int breedte)
        {
            Breedte = Hoogte = breedte;
        }
        public override int BerekenOppervlakte()
        {
            return base.BerekenOppervlakte();
        }
    }
}
