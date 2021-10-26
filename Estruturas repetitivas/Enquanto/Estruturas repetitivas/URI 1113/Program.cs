using System;

namespace URI_1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            string[] vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            while (X != Y)
            {
                if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}
