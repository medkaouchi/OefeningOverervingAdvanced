using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrricFigures
{
    abstract class GeometricFegure
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }
        private int oppervlakte;

        public int MyProperty
        {
            get { return oppervlakte; }
        }
        abstract public int BerekenOppervlakte();

    }
}
