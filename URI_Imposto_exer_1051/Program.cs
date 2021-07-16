using System;
using System.Globalization;

namespace URI_Imposto_exer_1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double acumula = 0;
            double value2 = 0;
            if (value >= 0 && value <= 2000)
            {
                Console.WriteLine("Isento");
            }

            if (value > 2000 && value <= 3000)
            {
                value2 = value - 2000;
                acumula = value2 * 8 / 100;
            }
            if (value > 3000 && value <= 4500)
            {
                value2 = value - 3000;
                acumula = (1000 * 8 / 100);
                acumula += (value2 * 18 / 100);
            }
            if (value > 4500)
            {
                value2 = value - 4500;
                acumula = (1000 * 8 / 100);
                acumula += (1500 * 18 / 100);
                acumula += (value2 * 28 / 100);
            }
            Console.WriteLine("R$ " + acumula.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
