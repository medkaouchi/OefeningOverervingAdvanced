using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirenTuin
{
    abstract class Dier
    {
        public virtual int Gewicht { get; set; }
        public abstract void Zegt();
        public override string ToString()
        {
            return base.ToString().Split('.')[1];
        }
        public override bool Equals(Object obj)
        {
            return base.GetType()==obj.GetType();
        }
    }
}
