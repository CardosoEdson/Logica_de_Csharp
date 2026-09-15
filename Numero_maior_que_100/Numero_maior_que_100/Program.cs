using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_maior_que_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine(" Digite um numero: ");
            n1 = double.Parse(Console.ReadLine());
            if (n1 > 100) 
            {
                Console.WriteLine(" Seu numero é:" + n1 + " É ele é maior que 100 ");
            }
            else { Console.WriteLine(" Seu numero é:" + n1 + " Ele não é maior que 100");
            }






        }
    }
}
