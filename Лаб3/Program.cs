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
            AL.Add(b);
            AL.Add(c);
            Console.WriteLine("Вывод площади элементов:"); //Вывод коллекции
            foreach (Fig f in AL)
                Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
