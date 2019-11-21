using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pry a = new Pry(2, 2); // Пример прямоугольникa
            a = new Pry { Shi = 2, Vis = 2 }; // Пример прямоугольникa
            a.Print();
            Console.ReadKey();
            return;
        }
    }
}
