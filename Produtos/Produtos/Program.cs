using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {/*  Crie um algprítmo para cadastro de produto: Código, fabricante, categoria, preço, estoque, valor total em estoque  */
            int codigo, estoque;
            string fabricante, categoria;
            double preco, total;
            Console.WriteLine(" Digite o codigo: ");
            codigo =  int.Parse(Console.ReadLine()); // obs o console.readline é como se fosse o leia
            Console.WriteLine(" Digite o Fabricante: ");
            fabricante = Console.ReadLine();
            Console.WriteLine(" Digite a categoria ");
            categoria = Console.ReadLine();
            Console.WriteLine(" Digite o preço ");
            preco = double.Parse(Console.ReadLine());// double é usado para o modo real
            Console.WriteLine(" Digite o estoque:");
            estoque = int.Parse(Console.ReadLine());
            total = preco * estoque;
            Console.WriteLine(" O valor total em estoque é " + total);


        }
    }
}
