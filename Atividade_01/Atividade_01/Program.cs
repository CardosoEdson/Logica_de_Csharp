using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01
{
    internal class Program
    {  /* *1-	Faça um algoritmo que leia dois valores inteiros A e B,
        * se os valores de A e B forem iguais, deverá somar os dois valores, 
        caso contrário devera multiplicar A por B.Ao final de qualquer um dos 
        cálculos deve - se atribuir o resultado a uma variável C e
        imprimir seu valor na tela.*/

        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine(" leia A");
                A = int.Parse(Console.ReadLine());
            Console.WriteLine(" leia B ");
                B = int.Parse(Console.ReadLine());

            if (A == B) {

                C = A + B; 

                Console.WriteLine(" O valor é igual ");

            }
            else { C = A * B; }

            Console.WriteLine($"O resultado em C é: {C}");
        }
    }
}
