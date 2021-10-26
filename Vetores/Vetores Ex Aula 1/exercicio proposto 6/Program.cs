using System;

namespace exercicio_proposto_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nomes[i] = vet[0];
                idades[i] = int.Parse(vet[1]);
            }

            int maior = idades[0];
            int pessoaMaisVelha = 0; 
            for(int i = 0; i < N; i++) { 
                if (idades[i] > maior) {
                    maior = idades[i];
                    pessoaMaisVelha = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[pessoaMaisVelha]);
        }
    }
}
