using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Лаб2;

namespace Лаб3
{
    class Program
    {
        static void Main(string[] args)
        { 
        Fig
            a = new Kva(2),
            b = new Pry(2, 3),
            c = new Kru(4);
        var AL = new ArrayList(); // Создание коллекции AL(ArrayList)
            AL.Add(a);
            AL.Add(c);
            AL.Add(b);
            Console.WriteLine("Вывод площади элементов:"); //Вывод коллекции AL(ArrayList)
            foreach (Fig f in AL)
                Console.WriteLine(f);
            var FL = new List<Fig>(); // Создание коллекции FL(List<Figure>)
            FL.Add(a);
            FL.Add(b);
            FL.Add(c);
            FL.Sort();
            foreach (Fig f in FL)// Вывод отсортированной коллекции FL(List<Figure>)
                Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
