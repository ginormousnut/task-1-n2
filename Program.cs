using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1__n2
{
    class Program
    {
        static void Main()
        {
            int n=0;
            double x;
            double s = Math.PI / 2;
            double e;
            double a;
            Console.WriteLine("Введите переменную>");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите погрешность>");
            e = Convert.ToDouble(Console.ReadLine());
            a= Math.Pow(-1, 1) * Math.Pow(x, 2 * 1 - 1) / (2 * 1 - 1);
            while (Math.Abs(a) > e)
            {
                n++;
                s += Math.Pow(-1, n) * Math.Pow(x, 2 * n - 1) / (2 * n - 1);
                a= Math.Pow(-1, n+1) * Math.Pow(x, 2 * (n+1) - 1) / (2 * (n+1) - 1);
            }
            Console.Write("Полученная частичная сумма ");
            Console.WriteLine(s);
            
            Console.Write("Полученное количество членов ");
            Console.WriteLine(n);
            e = e / 10;
            s = Math.PI / 2;
            n = 0;
            a = Math.Pow(-1, 1) * Math.Pow(x, 2 * 1 - 1) / (2 * 1 - 1);
            while (Math.Abs(a) > e)
            {
                n++;
                s += Math.Pow(-1, n) * Math.Pow(x, 2 * n - 1) / (2 * n - 1);
                a = Math.Pow(-1, n + 1) * Math.Pow(x, 2 * (n + 1) - 1) / (2 * (n + 1) - 1);
            }
            Console.Write("Полученная частичная сумма для погрешности, отличающееся на порядок ");
            Console.WriteLine(s);

            Console.Write("Полученное количество членов для погрешности, отличающееся на порядок ");
            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
