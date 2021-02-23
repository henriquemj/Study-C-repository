﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pooCalculaIdade
{
    class Pessoa
    {
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

        public void ExibirDados()
        {
            Console.WriteLine("Nome" + this.Nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            int idade = this.CalcularIdade();
            Console.WriteLine("Idade: "+ idade);
        }

        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - this.AnoNascimento;
            return idade;
        }
    }
}
