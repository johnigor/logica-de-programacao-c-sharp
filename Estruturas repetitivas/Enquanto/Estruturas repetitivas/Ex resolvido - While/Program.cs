using System;
using System.Globalization;
namespace Ex_resolvido___While
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0.0;
            cont = 0;
            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (cont == 0)
            {
                Console.WriteLine("impossivel calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
