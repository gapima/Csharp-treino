//using _06_ByteBank;


namespace _07_ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }


        private int _agencia;
        public int Agencia {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
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

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

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
