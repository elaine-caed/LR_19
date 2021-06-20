using System;

namespace _19_iw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть початкове значення X1min: ");
            string sx1Min = Console.ReadLine();
            double x1Min = Double.Parse(sx1Min);

            Console.Write("Введiть кiнцеве значення X1max: ");
            string sx1Max = Console.ReadLine();
            double x1Max = double.Parse(sx1Max);

            Console.Write("Введiть прирiст dX1: ");
            string sdx1 = Console.ReadLine();
            double dx1 = double.Parse(sdx1);

            Console.Write("Введiть початкове значення X2min: ");
            string sx2Min = Console.ReadLine();
            double x2Min = Double.Parse(sx2Min);

            Console.Write("Введiть кiнцеве значення X2max: ");
            string sx2Max = Console.ReadLine();
            double x2Max = double.Parse(sx2Max);

            Console.Write("Введiть прирiст dX2: ");
            string sdx2 = Console.ReadLine();
            double dx2 = double.Parse(sdx2);
            double y;
            double x1 = x1Min;
            double x2;
            double sum = 0;
            while (x1 <= x1Max)
            {
                x2 = x2Min;
                while (x2 <= x2Max)
                {
                    y = Math.Log(x1) / (Math.Pow(Math.Pow((0.6 * x1 * Math.Sin(x2) * Math.Cos(x1)), 4), 0.20));
                    if (y > 0)
                    {
                        Console.WriteLine("x1 = {0:#.##e+0}\tx2 = {1:#.##e+0}\t\ty = {2:#.##e+0}", x1, x2, y);
                    }
                    if (y == 0)
                    {
                        Console.WriteLine("x1 = {0:#.##e+0}\tx2 = {1:#.##e+0}\t\ty = {2}", x1, x2, y);
                    }
                    if (Math.Sin(x1) > 0 && Math.Sin(x2) > 0)
                    {
                        sum += (Math.Sin(x1) + Math.Sin(x2));
                    }
                    x2 += dx2;
                }
                x1 += dx1;
            }
            Console.WriteLine("Sum of positive Sin = {0:#.##e+0}", sum);
            Console.ReadKey();
        }
    }
}
