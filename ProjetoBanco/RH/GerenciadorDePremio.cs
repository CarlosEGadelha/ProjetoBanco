using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Funcionarios;

namespace ProjetoBanco.RH
{
    class GerenciadorDePremio
    {
        public double TotalPremio {get; set;}

        public void Registo(Funcionario funcionario)
        {
            TotalPremio += funcionario.CalculoPremio();       

        }

        public void Registo(Diretor diretor)
        {
            TotalPremio += diretor.CalculoPremio();

        }
    }
}
