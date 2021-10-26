using System;
using System.Globalization;

namespace entrada_de_dados
{
    class Program
    {
        static void main(string[]args)
        {
            /*checklist da aula:
             * ler um número inteiro
             * ler um caractere
             * ler um número double
             * ler um nome (única palavra), sexo (caractere F ou M), idade (inteiro) e altura (double)
             na mesma linha, armazenando-os em quatro variaveis com os devidos tipos*/

            /*int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet [0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet [3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));*/


            //ex proposto

            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);          
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProd);



            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));





            
            
            
        }
    }
}
