using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Najwiekszy_wspolny_dzielnik
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, reszta;
            Console.WriteLine("Podaj pierwszą liczbe");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                reszta = a % b;
                while (reszta != 0)
                {
                    a = b;
                    b = reszta;
                    reszta = a % b;
                }
                Console.WriteLine(b);
                Console.ReadKey(true);
            }
            else if (a < b)
            {
                reszta = b % a;
                while (reszta != 0)
                {
                    b = a;
                    a = reszta;
                    reszta = b % a;
                }
                Console.WriteLine(a);
                Console.ReadKey(true);
            }
            else if (a == b && a!=0)
            {
                Console.WriteLine(a);
                Console.ReadKey(true);
            }
            else if (a == 0 && b != 0)
            {
                Console.WriteLine(b);
                Console.ReadKey(true);
            }
            else if (b == 0 && a != 0)
            {
                Console.WriteLine(a);
                Console.ReadKey(true);
            }
            else
                Console.WriteLine("Dwa razy zero???");
            Console.ReadKey(true);




        }
    }
}
