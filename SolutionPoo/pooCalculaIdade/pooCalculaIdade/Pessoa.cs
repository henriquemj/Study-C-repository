using System;
using System.Collections.Generic;
using System.Text;

namespace pooCalculaIdade
{
    class Pessoa
    {
        public Pessoa(String nomePessoa, int anoNascimentoPessoa)
        {
            this.Nome = nomePessoa;
            this.AnoNascimento = anoNascimentoPessoa;
            this.CalcularIdade();
        }

        private int anoNascimento;
        public int AnoNascimento
        {
            get { return anoNascimento; }
            set { anoNascimento = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private int idade;

        public int Idade
        {
            get {
                this.CalcularIdade();
                return idade;
            }

        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome " + this.Nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            this.CalcularIdade();
            Console.WriteLine("Idade: "+ this.Idade);
        }

        private void CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            this.idade = ano - this.AnoNascimento;
        }
    }
}
