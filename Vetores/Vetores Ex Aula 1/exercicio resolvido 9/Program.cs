using System;
using System.Globalization;
namespace exercicio_resolvido_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                precoCompra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
            }

            //encontrar a quantidade para cada faixa de lucro desejada
            int contAbaixoDe10 = 0;
            int contEntre10E20 = 0;
            int contAcimaDe20 = 0;
            for (int i = 0; i < N; i++) {
                double lucro = precoVenda[i] - precoCompra[i];
                double porcentagemDeLucro = lucro / precoCompra[i] * 100.0;
                if (porcentagemDeLucro < 10.0) {
                    contAbaixoDe10++;
                }
                else if (porcentagemDeLucro <= 20.0) {
                    contEntre10E20++;
                }
                else {
                    contAcimaDe20++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

            double compraTotal = 0.0;
            double vendaTotal = 0.0;
            for (int i = 0; i < N; i++) {
                compraTotal = compraTotal + precoCompra[i];
                vendaTotal = vendaTotal + precoVenda[i];
            }

            double lucroTotal = vendaTotal - compraTotal;

            Console.WriteLine("Valor total de compra: " + compraTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + vendaTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
