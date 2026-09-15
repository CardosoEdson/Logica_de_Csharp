using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_escolar
{
    internal class Program
    {
        static void Main(string[] args)
        {/*  crie um algoritomo que peça: nome do aluno, nota 1, nota 2, nota 3, nota 4, (notas de 0 - 10),
  calcule a media e exiba na tela: o nome do aluno com a media*/

            double nota1, nota2, nota3, nota4, media;
            string nome;//string se refere ao cadeia
            Console.WriteLine(" Nome Do Aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine(" Escreva A nota1: ");
            nota1 = double.Parse(Console.ReadLine()); //usar o nome antes da variavel
            Console.WriteLine(" Escreva a nota2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Escreva a nota3: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Escreva a nota4 ");
            nota4 = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite A Media ");
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine(" nome" + nome + " media " + media);
            


        }
    }
}
