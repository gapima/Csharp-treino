using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora";
            //gabriela.cpf = "123.456.789-85";

            ContaCorrente conta = new ContaCorrente();

            

            //conta.titular = gabriela;
            conta.titular = new Cliente();
            if (conta.titular == null)//verifica se tem alguma referencia para conta.titular.
            {
                Console.WriteLine("Ops, referencia NULL");
            }

            conta.titular.nome = "Gabriela Costa";
            conta.titular.profissao = "Desenvolvedora";
            conta.titular.cpf = "123.456.789-85";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.titular.cpf = "123.456.789-85";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;
            
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

        }
    }
}
