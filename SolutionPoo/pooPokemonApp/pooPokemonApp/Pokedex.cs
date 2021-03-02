using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokemonApp
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
        }

        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            // Instanciar a lista
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bulbassaur", "Pokémon do tipo Planta Venenoso", 10);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mew", "Psiquico Lendário", 80);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "Psiquico Lendário", 70);
            this.pokemons.Add(p);
            p = new PokemonPlus("Flygon", "Pokémon Inseto Dragão",45);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "Pokémon Metal Psíquico", 50);
            this.pokemons.Add(p);
            p = new PokemonPlus("Muk", "Pokémon Venenoso", 35);
            this.pokemons.Add(p);
            p = new PokemonPlus("Giratina", "Pokémon Lendário",60);
            this.pokemons.Add(p);
        }

        //Método de Lista todos os pokémons
        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("Código do pokémon: " +i);
                this.Pokemons[i].ExibirDadosPokemon();
                //O comando de baixo faz a mesma função que o de cima.
                //Pokemon p = this.Pokemons[i];
                //p.ExibirDadosPokemon();
            }
        }
    }
}
