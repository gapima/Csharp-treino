//using _06_ByteBank;


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular  {get; set;}
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double saldo = 100;


        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                saldo = value;
            }
        }

        //public void SetSaldo(double saldo)
        //{
        //    if(saldo < 0)
        //    {
        //        return;
        //    }
          
        //    this.saldo = saldo;
        //}
        //public double GetSaldo()
        //{
        //    return saldo;
        //}
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            return true;


        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }

            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }






    }

}
