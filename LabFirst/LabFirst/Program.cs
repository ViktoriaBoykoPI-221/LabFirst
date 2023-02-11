using System;

namespace Cosmos
{
    class Zvesda
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число (a): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите показатель степени (n): ");
            int n = int.Parse(Console.ReadLine());

            double result = 1;

            for (int index = 0; index < n; ++index)
            {
                result *= a;
            }

            Console.Write("a^n = " + result);
        }
    }
}