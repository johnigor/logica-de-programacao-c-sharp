using System;
using System.Globalization;

namespace URI_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] casos = Console.ReadLine().Split(' ');
                double a = double.Parse(casos[0], CultureInfo.InvariantCulture);
                double b = double.Parse(casos[1], CultureInfo.InvariantCulture);
                double c = double.Parse(casos[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
