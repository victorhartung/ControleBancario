using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(long numero) : base(numero)
        {
        }

        public ContaCorrente(long numero, decimal saldo, Cliente titular) : base(numero, saldo, titular)
        {
        }
    }
}
