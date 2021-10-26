using System;

namespace URI_1078
{
    class Program
    {
        static void Main(string[] args) //TABUADA
        {
            int N;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                int resultado = N * i;
                Console.WriteLine(i + " x " + N + " = " + resultado);
                
            }
        }
    }
}
