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

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(tarles);

            Diretor luiza = new Diretor("854.947.113-45");
            luiza.Nome = "Luiza";
            luiza.Salario = 5000;

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario luizaTeste = luiza;

            Console.WriteLine("Bonificação de uma referencia de Diretor: " + luizaTeste.GetBonificacao());
            Console.WriteLine("Bonificação de uma referencia de Funcionário: " + luizaTeste.GetBonificacao());

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
