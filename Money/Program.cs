using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankrekening bankrekening= new Bankrekening("bnak1",50);
            SpaarRekening spaarrekening = new SpaarRekening("spaar1",5000);
            ProRekening prorekening = new ProRekening("pro1",5000);
            Console.WriteLine(bankrekening.BerekenRente());
            Console.WriteLine(spaarrekening.BerekenRente());
            Console.WriteLine(prorekening.BerekenRente());
            Console.ReadLine();
        }
    }
}
