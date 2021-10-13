using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();

            cliente.Nome = "Gabriel";
            cliente.CPF = "123.555.222-99";
            cliente.Profissao = "Dev";

            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = -10;

            Console.WriteLine(conta.Saldo);
        }
    }
}
