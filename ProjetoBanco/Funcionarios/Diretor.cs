using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Funcionarios
{
    class Diretor : Funcionario
    {
        public override double CalculoPremio()
        {
            return this.Salario + base.CalculoPremio();
        }

        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
            Console.WriteLine("O diretor foi construido");
        }
    }
}
