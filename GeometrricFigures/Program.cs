using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrricFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            RechtHoek rechthoek = new RechtHoek();
            rechthoek.Breedte = 3;
            rechthoek.Hoogte = 4;
            Console.WriteLine(rechthoek.BerekenOppervlakte());

            VierKant vierkant = new VierKant(4);
            Console.WriteLine(vierkant.BerekenOppervlakte());

            DrieHoek driehoek = new DrieHoek();
            driehoek.Breedte = 3;
            driehoek.Hoogte = 4;
            Console.WriteLine(driehoek.BerekenOppervlakte());

            Console.ReadLine();
        }
    }
}
