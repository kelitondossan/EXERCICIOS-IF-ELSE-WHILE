using System;

namespace ANALISANDO_PONTOS_CARTESIANOS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] VALORES = Console.ReadLine().Split(' ');
            int X = int.Parse(VALORES[0]);
            int Y = int.Parse(VALORES[1]);

            while ( X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("PRIMEIRA");
                }
                else if ( X < 0 && Y > 0)
                {
                    Console.WriteLine("SEGUNDO");
                }
                else if ( X < 0 && Y < 0)
                {
                    Console.WriteLine("TERCEIRO");

                }
                else
                {
                    Console.WriteLine("QUARTO");
                }
                VALORES = Console.ReadLine().Split(' ');
                X = int.Parse(VALORES[0]);
                Y = int.Parse(VALORES[1]);
            }
        }
    }
}
