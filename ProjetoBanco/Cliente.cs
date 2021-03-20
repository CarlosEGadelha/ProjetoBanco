using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int RG { get; set; }
        public Endereco Endereco { get; set; }

        public void ImprimeNome()
        {
            Console.WriteLine("O cliente é {0}", this.Nome);
        }
        public Cliente(string cpf, string cep)
        {
            if (cpf == "63275286509")
            {
                this.Nome = "Denis DJ";
                this.CPF = cpf;
                this.RG = 54342354;
            }
            else
            {
                this.Nome = "Charles Charlie";
                this.CPF = cpf;
                this.RG = 64334752;
            }
            this.Endereco = new Endereco(cep);
        }

        public Cliente(int rg, string cep)
        {
            if (rg == 64334752)
            {
                this.Nome = "Charles Charlie";
                this.CPF = "134323523";
                this.RG = rg;
            }
            else
            {
                this.Nome = "Denis DJ";
                this.CPF = "63275286509";;
                this.RG = rg;

            }
            this.Endereco = new Endereco(cep);
        }
    }
}
