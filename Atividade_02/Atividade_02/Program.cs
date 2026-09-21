using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_02
{
    internal class Program
    { /* 2-	Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário,
       * calcule quantos salários mínimos esse 
       usuário ganha e imprima na tela o resultado. (Base para o Salário mínimo R$ 1.518,00).*/

        static void Main(string[] args)
        {
            
            double salarioM = 1518.00, salarioU, resultado;
            
            Console.WriteLine(" O salario do usuario é");
            salarioU  = double.Parse(Console.ReadLine());

            resultado = salarioU / salarioM;

            Console.WriteLine($"Você ganha o equivalente a { resultado:F2} salários mínimos.");



        }
    }
}
