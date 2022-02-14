using System;
using System.Globalization;
namespace PROGRAMA_QUE_REPELE_SENHA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UM NUMERO");
            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while(X != 2002 )
            {
               
                Console.Write("SENHA INCORRETA ");
                X = double.Parse(Console.ReadLine());
                

            }
            Console.WriteLine("ACESSO PERMITIDO");
        }
    }
}
