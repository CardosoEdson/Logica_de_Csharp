using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_03
{
    internal class Program
    {  /* Faça um algoritmo que leia um valor qualquer e imprima na tela com um reajuste de 5%. */
        static void Main(string[] args)
        {
            double reajuste = 1.05, valor, valorfinal;

            Console.WriteLine(" Digite o Valor ");
            valor = double.Parse(Console.ReadLine());


            valorfinal = valor * reajuste;

            Console.WriteLine(" O valor com reajuste é: " + valorfinal );







        }
    }
}
