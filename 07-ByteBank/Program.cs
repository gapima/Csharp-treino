using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta1 = new ContaCorrente(0000, 55555);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(555, 00000);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta3 = new ContaCorrente(111, 50000);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}
