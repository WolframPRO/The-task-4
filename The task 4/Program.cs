using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите погрешность: ");
            double e;
            bool ok;

            do { ok = double.TryParse(Console.ReadLine(), out e); if (!ok || e < 0) { Console.WriteLine("Ошибка ввода"); } } while (!ok);

            double a = -1, b = 0;
            while (Math.Abs(b - a) > e)
            {
                a = b - (b - a) * f(b) / (f(b) - f(a));
                b = a + (a - b) * f(a) / (f(a) - f(b));
            }

            Console.WriteLine("Ответ: " + b);
            Console.ReadKey();
        }

        public static double f(double x_)
        {
            double x = x_;
            return x * x * x * x + 0.5 * x * x * x - 4 * x * x - 3 * x - 0.5;
        }
    }
}
