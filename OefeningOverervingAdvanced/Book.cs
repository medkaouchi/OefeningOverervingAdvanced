using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningOverervingAdvanced
{
    class Book
    {
        public virtual int ISBN { get; set; }
        public virtual string Title { get; set; }
        public virtual string Author { get; set; }

        public virtual double Price { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Author} ({ISBN}) {Price}";
        }

        public override bool Equals(object obj)
        {
            Book book = (Book)obj;
            return ISBN==book.ISBN;
        }
    }
}
