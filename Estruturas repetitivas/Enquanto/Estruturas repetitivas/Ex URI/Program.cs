using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cardapio = new List<string>(new string[] { "pasteis salgados" , "pasteis doces", "sucos" });
            List<Tuple<string, string>> combinacoes = new List<Tuple<string, string>>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i != j)//evitaria criar um pedido com duas opcoes iguais (ex: pastel salgado, pastel salgado, pastel salgado)
                    {
                        if (!(combinacoes.Contains(new Tuple<string, string>(cardapio[i], cardapio[j])) || combinacoes.Contains(new Tuple<string, string>(cardapio[j], cardapio[i]))))//elimina as permutaçoes, tipo pastel salgado - pastel doce, pastel doce - pastel salgado
                        {
                            Tuple<string, string> saquinho = new Tuple<string, string>(cardapio[i], cardapio[j]);
                            combinacoes.Add(saquinho);
                        }
                    }
                }
            }
            int k = 1;
            foreach (Tuple<string, string> saquinho in combinacoes)
                Console.WriteLine((k++).ToString() + " : " + saquinho.Item1 + " - " + saquinho.Item2);

            Console.ReadKey();
        }
    }
}