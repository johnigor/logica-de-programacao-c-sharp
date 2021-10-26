using System;
using System.Globalization;

namespace Estrutura_repetitiva_faça_enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
                F = 9.0 * C / 5.0 + 32;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');


        }
    }
}
