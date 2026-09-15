using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome; //variavel cadeia
            int idade; //variavel inteiro
            Console.WriteLine(" Digite seu nome: "); //variavel escreva
            nome = Console.ReadLine(); //variavel leia
            Console.WriteLine(" Digite sua idade ");
            idade = int.Parse(Console.ReadLine());//converte o que digirar para inteiro
            Console.WriteLine(" Parabens " + nome + " Você acabou de ganhar uma coca-cola ");
            Console.WriteLine(" \n você possui " + idade + " Anos, beba mais agua ");

        }
    }
}
