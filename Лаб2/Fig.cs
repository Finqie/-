using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    abstract class Fig : IPrint
    {

        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public abstract double Plo();

    }
}
