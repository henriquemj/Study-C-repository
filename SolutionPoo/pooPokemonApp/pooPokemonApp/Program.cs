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
            Pokemon p = new Pokemon("#001 Bulbasaur", "Bulbasaur é um pokémon do tipo Planta Venenoso");
            p.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}
