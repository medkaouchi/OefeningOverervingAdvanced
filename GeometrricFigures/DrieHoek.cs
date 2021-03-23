using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrricFigures
{
    class DrieHoek:GeometricFegure
    {
        public override int BerekenOppervlakte()
        {
            return Breedte*Hoogte/2;
        }
    }
}
