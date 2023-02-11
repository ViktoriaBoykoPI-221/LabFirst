using System;

namespace Universe
{
    class Cometa
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите число х (х >= 100): ");
            int x = int.Parse(Console.ReadLine());
            int number = x;

            do
            {
                number = number / 10;
                if (number < 100)
                {
                    do
                    {
                        number = number - 10;
                    }
                    while (number > 10);
                }
            }
            while (number > 100);
            int n = int.Parse(x.ToString().Remove(1, 1) + number);
            Console.Write("результат: " + n);
            Console.ReadKey();
        }
    }
}