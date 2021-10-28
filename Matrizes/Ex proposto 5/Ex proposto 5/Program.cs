using System;

namespace Ex_proposto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            string[] valores = Console.ReadLine().Split(' ');
            M = int.Parse(valores[0]);
            N = int.Parse(valores[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] C = new int[M, N];

            //armazenamento matriz 1
            for (int i = 0; i < M; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            //armazenamento matriz 2
            for (int i = 0; i < M; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < M; i++) { 
                for (int j = 0; j < N; j++) {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i = 0; i < M; i++) { 
                for (int j = 0; j < N; j++) {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
