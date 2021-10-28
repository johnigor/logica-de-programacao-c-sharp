using System;

namespace Ex_proposto_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            int soma = 0;
            for (int i = 0; i < N; i++) {
                for (int j = i + 1; j < N; j++) {
                    soma = soma + matriz[i, j];
                }                                
            }
            Console.WriteLine(soma);
        }
    }
}
