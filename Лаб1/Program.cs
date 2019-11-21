using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            Console.Title = "Коваль Иван РТ5-31Б";
            var korni = new List<double>();
            while (i == -1)
            {
                Console.ResetColor();
                double a, b, c, d;
                Console.WriteLine("Введите коэффициенты уравнения ");
                if (args.Length == 0)
                    return;

                if (args.Length != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэф. введены неверно! Введите коэф. повторно");
                    continue;
                }
                if (!Double.TryParse(args[0], out a) ||
                !Double.TryParse(args[1], out b) ||
                !Double.TryParse(args[2], out c))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэф. введены неверно! Введите коэф. повторно");
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if ((a == 0) && (c == 0) && (b == 0))
                {
                    Console.WriteLine("Корней бесконечно много");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    if ((a == 0) && (c == 0))
                    {
                        Console.WriteLine("0");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        if ((c == 0) && (b == 0))
                        {
                            Console.WriteLine("0");
                            Console.ReadKey();
                            return;
                        }
                    }
                }

                if ((a == 0) && (b == 0))
                { }
                else
                {
                    if (a == 0)
                    {
                        if ((c / b) <= 0)
                        {
                            korni.Add((Math.Sqrt(-c / b)));
                            korni.Add((-Math.Sqrt(-c / b)));
                        }
                    }
                    else
                    {
                        if (b == 0)
                        {
                            if ((c / a) <= 0)
                            {
                                korni.Add(Math.Sqrt(Math.Sqrt(-c / a)));
                                korni.Add(-Math.Sqrt(Math.Sqrt(-c / a)));
                            }
                        }
                        else
                        {
                            if (c != 0)
                            {
                                d = b * b - 4 * a * c;
                                if (d >= 0)
                                {
                                    double xx = ((-b + Math.Sqrt(d)) / (2 * a));
                                    double yy = ((-b - Math.Sqrt(d)) / (2 * a));
                                    if (xx >= 0)
                                    {
                                        korni.Add(Math.Sqrt((-b + Math.Sqrt(d)) / (2 *
                                       a)));
                                        korni.Add(-Math.Sqrt((-b + Math.Sqrt(d)) / (2 *
                                       a)));
                                    }
                                    if (yy >= 0)
                                    {
                                        korni.Add(Math.Sqrt((-b - Math.Sqrt(d)) / (2 *
                                       a)));
                                        korni.Add(-Math.Sqrt((-b - Math.Sqrt(d)) / (2 *
                                       a)));
                                    }
                                }
                            }
                            else
                            {
                                if ((b / a) <= 0)
                                {
                                    korni.Add((Math.Sqrt(-b / a)));
                                    korni.Add((-Math.Sqrt(-b / a)));
                                }
                                korni.Add(0);

                            }
                        }
                    }
                }

                foreach (int itt in korni)
                    i++;
                if (i == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет! Введите коэф. повторно");
                }
            }
            int k = 1;
            i = -1;
            int i1 = 0;
            foreach (int itt in korni)
                i++;
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (double itt in korni)
            {
                k = 0;
                for (i1 = 0; i1 < i; i1++)
                {
                    if (korni[i1] == korni[i]) k++;
                }
                if (k == 0)
                    Console.WriteLine(itt);
            }
            Console.ReadKey();
        }
    }
}