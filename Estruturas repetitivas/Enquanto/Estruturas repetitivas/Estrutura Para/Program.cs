using System;

namespace Estrutura_Para
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, soma;

            N = int.Parse(Console.ReadLine());
            soma = 0;
            for (int i = 1; i <= N; i++) {        //(início; condição; incremento) (i++ == i = i + 1)
                x = int.Parse(Console.ReadLine());
                soma += x;
            }

            Console.WriteLine(soma);

        }
    }
}
