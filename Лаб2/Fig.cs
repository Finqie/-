using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    public abstract class Fig : IPrint, IComparable
    {

        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public abstract double Plo();

        public int CompareTo(object obj)
        {
            return (Convert.ToInt32(Plo() - (obj as Fig).Plo()));
        }

    }
}
