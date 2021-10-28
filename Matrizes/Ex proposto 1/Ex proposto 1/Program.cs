using System;

namespace Ex_proposto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            string[] numeros = Console.ReadLine().Split(' ');
            M = int.Parse(numeros[0]);
            N = int.Parse(numeros[1]);

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++) { 
                for (int j = 0; j < N; j++) { 
                    if (matriz[i, j] < 0) {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}
