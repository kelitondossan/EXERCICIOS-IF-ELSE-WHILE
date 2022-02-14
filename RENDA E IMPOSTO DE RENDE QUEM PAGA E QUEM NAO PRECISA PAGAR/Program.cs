using System;
using System.Globalization;

namespace RENDA_E_IMPOSTO_DE_RENDE_QUEM_PAGA_E_QUEM_NAO_PRECISA_PAGAR
{
    class Program
    {
        static void Main(string[] args)
        { /*Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. 
            Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
            --------------------------------|-------------
             RENDA                          |IMPOSTO DE RENDA 
            ----------------------------------------------
            DE 0.00 A R$ 2000.00            | ISENTO
            DE R$ 200.01 ATE R$ 3000.00     |   8%
            DE R$ 3000.1 ATE R$ 4500.00     |  18%
            ACIMA DE R4 45000.00            |  28%
           
           */


            double SALARIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;
            if(SALARIO <= 2000.0)
            {
                imposto = 0.0;
            }
           else if (SALARIO <= 3000.0)
            {
                imposto = (SALARIO - 2000.0) * 0.8;

            }
          else if (SALARIO <= 4500.0)
            {
                imposto = (SALARIO - 3000.0) * 0.18 + 1000.0 * 0.08;

            }
            else
            {
                imposto = (SALARIO - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0;
            }
            if(imposto == 0.0)
            {
                Console.WriteLine("isento");

            }
            else
            {
                Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

    }
}
