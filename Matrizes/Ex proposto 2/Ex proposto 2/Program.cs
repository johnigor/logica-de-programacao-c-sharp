using System;

namespace Ex_proposto_2
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

            for (int i = 0; i < N; i++) {
                int x = 0; 
                for (int j = 0; j < N; j++) {
                    x = x + matriz[i, j];
                }

                Console.WriteLine(x);
            }
        }
    }
}
