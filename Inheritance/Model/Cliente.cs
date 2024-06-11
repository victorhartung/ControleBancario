using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model
{
    public class Cliente
    {

        private string _email;
        private string _nome;
        private string _cpf;
        private int _anoNascimento;

        public Cliente() { }

        public Cliente(string nome, string cpf, int anoNascimento, string email)
        {
            _email = email;
            _nome = nome;
            _cpf = cpf;
            _anoNascimento = anoNascimento;

        }

        public string Email 
        {  
            get { return _email; }
            set { _email = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cpf
        {
            get { return _cpf; }
            set 
            { 
                if(value.Length == 11 && long.TryParse(value, out _))
                {
                    _cpf = value;
                }
                else
                {
                    throw new ArgumentException("O cpf deve ter 11 dígitos");
                }
                
            }
        }

        public int AnoNascimento
        {

            get { return _anoNascimento; }
            set
            {

                if (CalcularIdade(value) < 18)
                {
                    throw new ArgumentException("O cliente deve ter mais de 18 anos.");
                }

                _anoNascimento = value;
            }

        }

        private int CalcularIdade(int anoNascimento)
        {
            int anoAtual = DateTime.Today.Year;

            return anoAtual - anoNascimento;
        }



    }
}
