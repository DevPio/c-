using System;
using ByteBank;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Orientação a Objetos c#.");

            ContaConrrente conta = new ContaConrrente(2424235,1212121);

            ContaConrrente contaLuccas = new ContaConrrente(2424235, 1212121);

           

            Console.ReadLine();

        }
    }
}
