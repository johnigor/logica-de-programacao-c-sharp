using System;

namespace Aula_2_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            Console.WriteLine("Que horas são?");
            hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}
