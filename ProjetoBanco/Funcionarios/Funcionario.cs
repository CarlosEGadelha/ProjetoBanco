using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Funcionarios
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double CalculoPremio() {
            return this.Salario *0.1;
        }

        public Funcionario(string nome, string cpf, double salario)
        {
            Console.WriteLine("O funcionario foi construido");
            this.Nome = nome;
            this.CPF = cpf;
            this.Salario = salario;
        }

    }
}
