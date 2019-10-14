using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    class Fig
    {
        //public void Plo()
        //{
        //}
    }
    class Pry: Fig
    {
        public double Shi { get; set; }
        public double Vis{ get; set; }
        public Pry() { }
        public Pry(double a, double b)
        {
            Shi = a;
            Vis = b;
        }
    }
    class Kva : Pry
    {
        public Kva(double a)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
