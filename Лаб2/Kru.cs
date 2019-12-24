using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    public class Kru : Fig
    {
        public override double Plo()
        {
            return 3.14 * Rad * Rad;
        }
        public double Rad { get; set; }
        public Kru(double a)
        {
            Rad = a;
        }
        public override string ToString()
        {
            return ($"Круг. Площадь {Plo()}.");
        }
    }
}
