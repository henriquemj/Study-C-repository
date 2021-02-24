﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1;
            Pessoa p2;
            Pessoa p3;
            Console.WriteLine("Determina qual pessoa é a mais velha");

            // Leitura de dados da 1 pessoa
            Console.WriteLine("Nome da 1 pessoa");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 1 pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            // Leitura de dados da 2 pessoa
            Console.WriteLine("Nome da 2 pessoa");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 2 pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            // Leitura de dados da 3 pessoa
            Console.WriteLine("Nome da 3 pessoa");
            String nome = Console.ReadLine();
            Console.WriteLine("Idade da 3 pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            p3 = new Pessoa(nome, idade);

            //Lógica
              if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
              else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é: ");
                    p2.ExibirDados();
                }

                else
                {
                    if ((p3.Idade > p1.Idade) && (p2.Idade > p2.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é: ");
                        p3.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine("Todas as pessoas possuem a mesma idade ");
                        p3.ExibirDados();
                    }

                }
                        
              }

            Console.ReadKey();
            }
        }
    }