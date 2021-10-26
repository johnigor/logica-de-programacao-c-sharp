using System;

namespace URI_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
           
            for (int i = 0; i < n; i++) {
                string[] teste = Console.ReadLine().Split(' ');
                int x = int.Parse(teste[0]);
                int y = int.Parse(teste[1]);           

                if (x > y)
                {
                    int aux = x;
                    x = y;
                    y = aux;
                }

                int soma = 0;
                for (int j = x +1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
