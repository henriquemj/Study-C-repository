using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
   public class PokemonPlus:Pokemon
    {   
        public PokemonPlus():base()
        {
            this.Poder = 0;
        }

        public PokemonPlus(String nome, String descricao, int poder) : base(nome, descricao)
        {
            this.Poder = poder;
        }
        public int Poder { get; set; }

        public void ExibirDadosPokemonPlus()
        {
            Console.WriteLine("Nome do pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokèmon: " + this.Descricao);
            Console.WriteLine("Descrição do Pokèmon: " + this.Descricao);
        }

    }
}
