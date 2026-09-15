using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_vinho
{
    internal class Program
    { /* Construa um programa que permita fazer o levantamanto do estoque de vinhos de uma adega, tendo como dados de entrada
       * tipos de vinho, sendo: "T" para tinto e "B" para branco. como a qauntidade de vinhos é desconhecida, utilize a leta " F"
       * para finalizar.Após finalizar o programa deve mostrar a quantidade de cada vinho na adega */

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
░█████╗░██████╗░███████╗░██████╗░░█████╗░  ██████╗░███████╗  ██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔════╝██╔════╝░██╔══██╗  ██╔══██╗██╔════╝  ██║░░░██║██║████╗░██║██║░░██║██╔══██╗██╔════╝
███████║██║░░██║█████╗░░██║░░██╗░███████║  ██║░░██║█████╗░░  ╚██╗░██╔╝██║██╔██╗██║███████║██║░░██║╚█████╗░
██╔══██║██║░░██║██╔══╝░░██║░░╚██╗██╔══██║  ██║░░██║██╔══╝░░  ░╚████╔╝░██║██║╚████║██╔══██║██║░░██║░╚═══██╗
██║░░██║██████╔╝███████╗╚██████╔╝██║░░██║  ██████╔╝███████╗  ░░╚██╔╝░░██║██║░╚███║██║░░██║╚█████╔╝██████╔╝
╚═╝░░╚═╝╚═════╝░╚══════╝░╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═════╝░");
            Console.ResetColor();
            string tipos;
            int tinto = 0, branco = 0;

            Console.WriteLine(" Digite o tipo do vinho ( T para tinto, B para branco, F para Finalizar): ");
            tipos = Console.ReadLine();




            while (tipos != "f")
            {
                Console.WriteLine(" Programa Finalizado ");

                if (tipos == "t")
                {
                    tinto++;
                }
                else if (tipos == "b")
                {
                    branco++;
                }
                Console.WriteLine("Digite o próximo vinho  ou f pra finalizar ):");
                tipos = Console.ReadLine();
            }

            Console.WriteLine("Quantidade de vinho Tinto: " + tinto);
            Console.WriteLine("Quantidade de vinho Branco: " + branco);
        

        }
    }
}
