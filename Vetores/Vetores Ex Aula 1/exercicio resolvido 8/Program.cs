using System;
using System.Globalization;

namespace exercicio_resolvido_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] alturas = new double[N];
            char[] sexos = new char[N];

            for(int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(valores[0], CultureInfo.InvariantCulture);
                sexos[i] = char.Parse(valores[1]);
            }

            //imprimindo menor altura
            double menor = alturas[0];
            for (int i = 0; i < N; i++) { 
                if (alturas[i] < menor) {
                    menor = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));

            //imprimindo maior altura
            double maior = alturas[0];
            for (int i = 0; i < N; i++) { 
                if (alturas[i] > maior) {
                    maior = alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));

            //media das alturas das mulheres
            double soma = 0.0;
            int cont = 0;
            for (int i = 0; i < N; i++) { 
                if (sexos[i] == 'F') {
                    soma = soma + alturas[i];
                    cont++;
                }
            }
            double media = soma / cont;
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));

            //como são apenas 2 opçoes, não é necessário o for para contar a qtd de homens
            int numeroHomens = N - cont;
            Console.WriteLine("Numero de homens = " + numeroHomens);
        }
    }
}
