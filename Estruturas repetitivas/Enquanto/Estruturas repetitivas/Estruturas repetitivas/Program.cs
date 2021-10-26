using System;

namespace Estruturas_repetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamagotchis, qtdTamagotchis, valorPossuido;
            tamagotchis = 12;
            qtdTamagotchis = 1;
            valorPossuido = 20;

            while (tamagotchis > 1 && valorPossuido > tamagotchis) {
                tamagotchis = tamagotchis - 1;
                qtdTamagotchis = qtdTamagotchis + 1;
                valorPossuido = valorPossuido - tamagotchis;
            }
            
            Console.WriteLine("Você pode comprar " + qtdTamagotchis + " tamagotchis com R$20,00");


        }
    }
}
