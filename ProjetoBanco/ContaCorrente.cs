using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    class ContaCorrente
    {
        public Cliente Titular { get; private set; }
        private int _agencia;
        public int Numero { get; private set; }
        private double _saldo = 0;
        public static int TotalContasCorrentes { get; private set; }

        public ContaCorrente(int agencia, int numero, Cliente titular) {
            this.Agencia = agencia;
            this.Numero = numero;
            this.Titular = titular;
            ContaCorrente.TotalContasCorrentes++;
        }

        public int Agencia
        {
            get
            {
                return this._agencia;
            }
            private set
            {
                if (value > 0)
                {
                    this._agencia = value;
                }
            }
        }

    public double Saldo {
            get 
            {
                return this._saldo;
            }
            set 
            {
                if (value >= 0) {
                    this._saldo = value;
                }
            }
        }

        public void ImprimeSaldo(double valor) {
            this._saldo += valor;
            Console.WriteLine("Foi depositado {0}", valor);
        }

        public void Depositar(double valor){
            this._saldo += valor;
            Console.WriteLine("Foi depositado {0}",valor);
        }

        public bool Sacar(double valor) {
            if (valor <= this._saldo)
            {
                this._saldo += valor;
                Console.WriteLine("Foi sacado {0}", valor);
                return true;
            }
            Console.WriteLine("Saque não realizado. Você não tem saldo.");
            return false;
        }

        public bool Transferencia(double valor,ContaCorrente contaTransferencia) {
            if (valor <= this._saldo) {
                this._saldo -= valor;
                contaTransferencia.Depositar(valor);
                Console.WriteLine("Você transferiu {0} para a conta de {1}", valor, contaTransferencia.Titular.Nome);
                return true;
            }
            Console.WriteLine("Não foi possivel realizar a transferência");
            return false;
        }
    }
}
