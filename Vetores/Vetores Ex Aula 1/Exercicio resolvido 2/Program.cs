using System;
using System.Globalization;

namespace Exercicio_resolvido_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] numerosReais = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(numerosReais[i], CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F1",CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();
            double soma = 0.0;

            for (int i=0; i<n; i++)
            {                
                soma = soma + vet[i];
            }
            double media = soma / n;            
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            media = soma / n;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
