using System;

namespace pooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a Idade de uma pessoa");
            Console.WriteLine("Nome da pessoa: ");
            String nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Pessoa p;
            p = new Pessoa(nome, ano);
            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
