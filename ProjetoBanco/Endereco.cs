using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    class Endereco
    {
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(string cep) {
            if (cep == "08743000")
            {
                this.Logradouro = "Av. Rio Bonito";
                this.CEP = cep;
                this.Cidade = "São Paulo";
                this.Estado = "SP";
            }
            else {
                this.Logradouro = "Rua domingues São Felix";
                this.CEP = cep;
                this.Cidade = "São Paulo";
                this.Estado = "SP";
            }
        }
    }
}
