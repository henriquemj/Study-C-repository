using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBanco.Funcionarios;

namespace NewBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario tarles = new Funcionario();
            tarles.Nome = "Tarles";
            tarles.CPF = "631.789.274-03";
            tarles.Salario = 200;

            gerenciador.Registrar(tarles);

            Diretor luiza = new Diretor();
            luiza.Nome = "Luiza";
            luiza.CPF = "854.947.113-45";
            luiza.Salario = 5000;

            gerenciador.Registrar(luiza);

            Console.WriteLine(tarles.Nome);
            Console.WriteLine(tarles.GetBonificacao());

            Console.WriteLine(luiza.Nome);
            Console.WriteLine(luiza.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();

        }
    }
}
