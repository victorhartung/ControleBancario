using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model
{
    public class ContaCaixinha : Conta
    {

        private const decimal IncrementoDeposito = 1.00m;
        private const decimal DecrementoSaque = 5.00m;

        public ContaCaixinha(long numero) : base(numero)
        {
        }

        public ContaCaixinha(long numero, decimal saldo, Cliente titular) : base(numero, saldo, titular)
        {
        }

        public new void Deposito(decimal valor)
        {
            if (valor < 1.00m)
            {
                throw new ArgumentException("Depósitos inferiores a 1,00 não são permitidos.");
            }

            base.Deposito(valor);
            _saldo += IncrementoDeposito;
        }
        public new decimal Saque(decimal valor)
        {
            decimal valorTotal = valor + TaxaSaque;

            if (_saldo - valorTotal - DecrementoSaque < 0)
            {
                throw new ArgumentException("Valor do saque ultrapassa o saldo.");
            }

            base.Saque(valor);
            _saldo -= DecrementoSaque;
            return _saldo;
        }

    }

}
