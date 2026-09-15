using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_Bissexto
{
    internal class Program
    { /*
             6.Ano Bissexto
            Determine se um ano é bissexto. Um ano é bissexto se for divisivel po 4, mas nao por 100, a nao ser que seja divisivel por 400.
            .entrada :2024
            .saida esperada: Ano bissexto */ 
        static void Main(string[] args) 
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
░█████╗░███╗░░██╗░█████╗░  ██████╗░██╗░██████╗░██████╗███████╗██╗░░██╗████████╗░█████╗░
██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██║██╔════╝██╔════╝██╔════╝╚██╗██╔╝╚══██╔══╝██╔══██╗
███████║██╔██╗██║██║░░██║  ██████╦╝██║╚█████╗░╚█████╗░█████╗░░░╚███╔╝░░░░██║░░░██║░░██║
██╔══██║██║╚████║██║░░██║  ██╔══██╗██║░╚═══██╗░╚═══██╗██╔══╝░░░██╔██╗░░░░██║░░░██║░░██║
██║░░██║██║░╚███║╚█████╔╝  ██████╦╝██║██████╔╝██████╔╝███████╗██╔╝╚██╗░░░██║░░░╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚═════╝░╚═╝╚═════╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░ ");
            Console.ResetColor();
            int ano;

            Console.WriteLine("escreva esse ano é bissexto");
            ano = int.Parse(Console.ReadLine ());

            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine(" Ano bissexto ");
            }
           else if(ano % 400 == 0)
            {
                Console.WriteLine(" Ano bissexto ");
            }
            else
            {
                Console.WriteLine(" não bissexto ");
            }
               


           




        }
    }
}
