using System;
using System.Globalization;

namespace Exercicio_resolvido_Aula_20_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler as medidas da largura e comprimento
            de um terreno retangular com uma casa decimal,
            bem como o valor do metro quadrado do terreno
            com duas casas decimais. Em seguida, o programa
            deve mostrar o valor da área do terreno,
            bem como o valor do preço do terreno,
            ambos com duas casas decimais, conforme exemplo:*/


            double largura, comprimento, precoMetroQuadrado, area, preco;

            Console.WriteLine("Digite a largura: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço do metro quadrado: ");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("Área = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço Total = " + preco.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadLine();





















        }
    }
}
