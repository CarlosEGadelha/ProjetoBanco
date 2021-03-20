using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine(ContaCorrente.TotalContasCorrentes);
        }
    }
}
