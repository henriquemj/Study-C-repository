using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                Console.Clear();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                if (resp == 2)
                {
                    pokedex.ListarPokemons();
                    Console.Write("Digite o código do pokémon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    // pegar o pokemon do player
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    //Definir o pokemon do PC
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];
                    //batalhar
                    Console.WriteLine("Dados dos pokémons que iram lutar");
                    Console.WriteLine("Dados do seu pokémon");
                    pPlayer.ExibirDadosPokemonPlus();
                    Console.WriteLine("Dados do pokemon do PC");
                    pPC.ExibirDadosPokemonPlus();
                    if (pPlayer.Poder >= pPC.Poder)
                    {
                        Console.WriteLine("Parabéns!!! Você foi o vencedor");
                    }
                    else
                    {
                        Console.WriteLine("Que pena!!! Você perdeu essa batalha");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadKey();
        }
        static int Menu()
        {
            Console.WriteLine("Pokémon-- Jogo de Batalha");
            Console.WriteLine("0 -  Sair do Jogo");
            Console.WriteLine("1 - Listar todos os Pokémons da Pokedex");
            Console.WriteLine("2 - Batalhar");
            Console.Write("O que deseja fazer: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
