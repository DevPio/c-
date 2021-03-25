

namespace ByteBank
{
    public class ContaConrrente
    {

        private Cliente titular;
        private double _agencia;
        private static int totalContas;
        private double _conta;
        private double _saldo = 0;


        public static int TotalContas
        {
            get
            {
                return totalContas;
            }
            private set
            {
                totalContas = value;
            }
        }
        public double Conta 
        {
            get
            {
                return this._conta;
            } 
            set
            {
                if (value <= 0) return;


                this._conta = value;
            }
                
                
        }
        public double Agencia { get; set; }
        public Cliente Titular
        {
            get
            {
               
                return this.titular;
            }
            set
            {
              
                if (!(this.titular == null))
                    return;

                this.titular = value;


                
            }
        }

       
        public double Saldo
        {
             get 
            {

                return this._saldo;
            
            }
            set
            {
                if (value > 0)
                {
                    
                    this._saldo = value;
                }

                return;
            }
        }

        public ContaConrrente(int agencia, int conta)
        {
            this.Agencia = agencia;
            this.Conta = conta;
            totalContas++;
        }

        
        public string Sacar(double valorSaque)
        {

            if (this._saldo >= valorSaque)
            {

                this._saldo -= valorSaque;

                return "Valor sacado com sucesso, seu saldo é " + this._saldo;
            }
            else if (valorSaque == 100 && this._saldo < valorSaque)
            {
                this._saldo = -100;
                return "Valor sacado com sucesso, seu saldo é " + this._saldo;
            }

            return "seu saldo é insuficente para saque";






        }

        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                this._saldo += valorDeposito;


            }

        }

        public bool Transferir(double valor, ContaConrrente conta)
        {
            if (this._saldo >= valor)
            {

                this._saldo -= valor;
                conta.Depositar(valor);

                return true;
            }



            return false;



        }

    }
}