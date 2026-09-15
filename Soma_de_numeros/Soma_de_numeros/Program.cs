using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, subitrair;
            Console.WriteLine(" digite o primeiro numero: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o segundo numero: ");
            number2 = int.Parse(Console.ReadLine());
            subitrair = number1 - number2;
            Console.WriteLine(" O resultado é " + subitrair );
        }
    }
}
