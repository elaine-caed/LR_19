using System;

namespace LR_19a
{
    class Program
    {
        static double Function(double x1, double x2)
        {
            return (45 * x1 * Math.Cos(x2) + Math.Pow(9 * x2 * Math.Pow(x1, 3), 0.5));
        }
        static void Main(string[] args)
        {
        StartOfCalculations:
            Console.Write("Введiть початок вiдрiзку iнтегрування a: ");
            string sa = Console.ReadLine();
            double a = double.Parse(sa);
            Console.Write("Введiть кiнець вiдрiзку iнтегрування b: ");
            string sb = Console.ReadLine();
            double b = double.Parse(sb);
            Console.Write("Введiть x: ");
            string sx = Console.ReadLine();
            double x = double.Parse(sx);
            Console.Write("Введiть n: ");
            string sn = Console.ReadLine();
            double n = double.Parse(sn);
            double x1 = 2*x, x2 = 5*x;
            double Intgrl = 0;
            double h, y;
            h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                y = Function(x1, x2);
                x = i + h;
                Intgrl += y / h;
            }
            Console.WriteLine("Iнтеграл функцiї на вiдрiзку [{0}, {1}] становить {2:#.######}", a, b, Intgrl);
            Console.Write("Повторити розрахунок (y - так) ? ");
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            Console.WriteLine();
            if (pressedKey.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                goto StartOfCalculations;
            }
        }
    }
}
