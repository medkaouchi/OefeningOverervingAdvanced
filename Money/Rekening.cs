using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    abstract class Rekening
    {
        public virtual string Rekeningnummer { get; set; }
        public virtual double Saldo { get; set; }

        public Rekening(string rn,double s)
        {
            Rekeningnummer = rn;
            Saldo = s;
        }
        public virtual void VoegGeldToe(double bedrag)
        {
            if(bedrag>=0)
            Saldo += bedrag;
        }
        public virtual void HaalGeldAf(double bedrag)
        {
            if (bedrag <= Saldo)
                Saldo -= bedrag;
            else
                Console.WriteLine("Bedrag is te hoog!");
        }
        public virtual double BerekenRente()
        {
            return Saldo * 0 / 100;
        }
    }
}
