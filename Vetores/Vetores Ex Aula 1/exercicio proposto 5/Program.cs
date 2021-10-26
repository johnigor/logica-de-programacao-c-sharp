using System;
using System.Globalization;

namespace exercicio_proposto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine();

            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(valores[i]);
            }

            double soma = 0;
            int cont = 0;
            for (int i = 0; i < N; i++) { 
                if (vet[i] % 2 == 0) {
                    soma = soma + vet[i];
                    cont++;
                }                
            }
            double media = soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));        }
    }
}
