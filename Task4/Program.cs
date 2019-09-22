using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int f = 1;
            Console.WriteLine("Введите число");
            n = int.Parse(Console.ReadLine());

            for (int c = n; c > 1; c--)
                f = f * c;
            Console.WriteLine("Факториал  = " + f);
            Console.ReadLine();
        }
    }
}
