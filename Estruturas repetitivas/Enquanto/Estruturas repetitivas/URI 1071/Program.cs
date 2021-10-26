using System;

namespace URI_1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;
            soma = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                    soma = soma + i;
            }

            Console.WriteLine(soma);

        }
    }
}
