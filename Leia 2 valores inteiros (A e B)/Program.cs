using System;
using System.Globalization;

namespace Leia_2_valores_inteiros__A_e_B_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
           // seguir, calcule e mostre o valor da conta a pagar.

           /*1 cachorro quente R$ 4.00 
             2 x-salada R$ 4.50
             3 x-bacon R$ 5.00
             4 torrada simples R% 2.00
             5 refrigerante   R$ 1.50*/

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores [0]);

            int quantidade = int.Parse(valores[1]);


            double total;
            if (codigo ==1)
            {
                total = quantidade * 4.0;

            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;

            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if ( codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else {
                total = quantidade * 1.5;
               }
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
