using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewBanco.Funcionarios;
using NewBanco.Sistemas;

namespace NewBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();


            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor luiza = new Diretor("123.674.911-23");
            luiza.Nome = "Luiza";
            luiza.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("214.528.457-12");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            Autenticavel pedro = pedro = new Designer("874.658.987-98");
            pedro.Nome = "Pedro";

            sistemaInterno.Logar(pedro, "test");
            sistemaInterno.Logar(luiza, "123");
            sistemaInterno.Logar(camila, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Autenticavel pedro = new Designer("874.658.987-98");
            pedro.Nome = "Pedro";

            Autenticavel luiza = new Diretor("123.674.911-23");
            luiza.Nome = "Luiza";

            Autenticavel igor = new Auxiliar("857.658.745-45");
            igor.Nome = "Igor";

            Autenticavel camila = new GerenteDeConta("214.528.457-12");
            camila.Nome = "Camila";

            Autenticavel henrique = new Desenvolvedor("478.521.474-98");
            henrique.Nome = "Henrique";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(luiza);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
