using System;

namespace Exercicio_resolvido_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] matriz;

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            matriz = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
                        
            for (int i = 0; i < M; i++) {
                int x = 0;
                for (int j = 0; j < N; j++) {
                    x = x + matriz[i, j];
                }
                Console.WriteLine(x);
            }
            
        }
    }
}
