using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Bandas
{
    internal class Program
    {/* 
      se / enquanto / para / caso
      if / while / for / switch

        Crie um sistema de cadastro de Álbuns de um artista / banda em que seá possível cadastrar
        um número x de músicas informada pelo usuário. Crie um menu de opções para isso

        */
     
  
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 4)
            {
                Console.Clear(); // limpa a tela 
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@"
        ░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░███████╗  ██████╗░███████╗
        ██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██╔════╝  ██╔══██╗██╔════╝
        ██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░█████╗░░  ██║░░██║█████╗░░
        ██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██╔══╝░░  ██║░░██║██╔══╝░░
        ╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗  ██████╔╝███████╗
        ░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝  ╚═════╝░╚══════╝

        ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
        ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
        ██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
        ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
        ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
        ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" 1 - Cadastrar Album da Banda ");
                Console.WriteLine(" 2-Cadastrar Album Do Artista ");
                Console.WriteLine(" 3-cadastar Músicas ");
                Console.WriteLine(" 4 sair do programa ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("saindo do  programa !!! tchau tchau !! :)");
                        break;
                }





            }
        }
    }
}
