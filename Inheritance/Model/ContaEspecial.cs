using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model
{
    public class ContaEspecial : Conta
    {

        private decimal _limite;

        public ContaEspecial(long numero) : base(numero)
        {
        }

        public ContaEspecial(long numero, decimal saldo, decimal limite, Cliente titular) : base(numero, saldo, titular)
        {
            _limite = limite;
        }

        public decimal Limite
        {
            get { return _limite; }
            set { _limite = value; }

        }

        public bool Sacar(decimal valor)
        {

            decimal valorTotal = valor + TaxaSaque;

            if(_saldo + Limite >= valorTotal)
            {
                _saldo -= valorTotal;
                return true;
            }
            else
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo e o limite disponível");
            }

        }

        public void Transferir(decimal valor, Conta contaDestino)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("O valor da transferência deve ser maior que 0");
            }
            if(_saldo + Limite < valor)
            {
                throw new InvalidOperationException("Saldo e limite insuficientes para realizar transferência");
            }

            this.Saldo -= valor;
            contaDestino.Deposito(valor);
        }

    }
}
