using System;

namespace EXERCICIOS_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MOSTRA SE O NUMERO E NEGATIVO ou nao negativo");
            int NUMERO = int.Parse(Console.ReadLine());


            if (NUMERO < 0) 
            {
                Console.WriteLine("negativo");
            }
            else
            {
                Console.WriteLine("nao negativo");
            }
            

        }
    }
}
