using System;
using System.Globalization;

namespace ESTRUTURA_DE_REPETIÇÃO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
                //ENTRADA DE DADOS 
            Console.Write("DIGITE UM NUMERO ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)// mostra os resultados de repetição se for verdadeiro se der um numero negativo o azplicativo para e mostra a mensagem ("numero negativo! nao se aplica no quesito proposto  que esta procurando );
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                
                Console.Write("digite oujtro numero ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            // mensagem citada no texto da entrada de dados
            Console.WriteLine("numero negativo! Não se aplica no quesito proposto que esta procurando");
        }
    }
}
