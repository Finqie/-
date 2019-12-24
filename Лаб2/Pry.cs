using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    public class Pry : Fig
    {
        public override double Plo()
        {
            return Shi * Vis;
        }
        public double Shi { get; set; }
        public double Vis { get; set; }
        public Pry() { }
        public Pry(double a, double b)
        {
            Shi = a;
            Vis = b;
        }
        public override string ToString()
        {
            return ($"Прямоугольник. Площадь {Plo()}.");/*{base.ToString()}*/
        }
    }
}
