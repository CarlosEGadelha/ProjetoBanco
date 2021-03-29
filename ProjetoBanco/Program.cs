using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Funcionarios;
using ProjetoBanco.RH;

namespace ProjetoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ContaCorrente ccDoCharles = new ContaCorrente(523, 653, new Cliente(64334752, "08333000"));
            ContaCorrente ccDoDennis = new ContaCorrente(-123, 654,new Cliente("63275286509", "08743000"));
            ccDoDennis.Saldo = 100;
            ccDoCharles.Saldo = 300;

            Console.WriteLine("-----------------------------");
            Console.WriteLine(ccDoDennis.Titular.Nome);
            Console.WriteLine(ccDoDennis.Saldo);
            Console.WriteLine(ccDoDennis.Agencia);
            Console.WriteLine("-----------------------------");
            Console.WriteLine(ccDoCharles.Titular.Nome);
            Console.WriteLine(ccDoCharles.Saldo);
            Console.WriteLine(ccDoCharles.Agencia);
            Console.WriteLine("-----------------------------");
            Console.WriteLine(ContaCorrente.TotalContasCorrentes);*/

            Funcionario camera1 = new Funcionario("Kleber", "111.111.111-00", 1000);

            Funcionario camera2 = new Funcionario("Joe", "222.222.222-00", 1100);

            Diretor boninho = new Diretor("Boninho", "333.333.333-00", 10000);

            GerenciadorDePremio gp = new GerenciadorDePremio();

            Console.WriteLine("O bonus do camera1 é: " + camera1.CalculoPremio());
            Console.WriteLine("O bonus do camera2 é: " + camera2.CalculoPremio());
            Console.WriteLine("O bonus do Boninho é: " + boninho.CalculoPremio());

            gp.Registo(camera1);
            gp.Registo(camera2);
            gp.Registo(boninho);

            Console.WriteLine(gp.TotalPremio);

        }
    }
}
