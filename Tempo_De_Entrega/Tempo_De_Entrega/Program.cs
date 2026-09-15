using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempo_De_Entrega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.WriteLine(" Digite o tempo da entrega: ");
            time = int.Parse(Console.ReadLine());
            if (time <= 15)
            {
                Console.WriteLine(" Entrega perfeita! Bônus Garantido.");
            }
            // colocar o ( E ) = &&
            if (time > 15 && time < 30)
            {

                {
                    Console.WriteLine(" pizza entregue a tempo, sem Bônus.");
                }
                if (time >= 30)
                {
                    Console.WriteLine(" A pizza esfriou! Peter foi demitido! ");
                }
            }
        }
    }
}
