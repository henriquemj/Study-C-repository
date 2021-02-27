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

        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializaLista()
        {
            // Instanciar a lista
            this.pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Bulbassaur", "Pokémon do tipo Planta Venenoso");
            this.pokemons.Add(p);
            p = new Pokemon("Mew", "Psiquico Lendário");
            this.pokemons.Add(p);
            p = new Pokemon("Metwo", "Psiquico Lendário");
            this.pokemons.Add(p);
            p = new Pokemon("Flygon", "Pokémon Inseto Dragão");
            this.pokemons.Add(p);
            p = new Pokemon("Metagross", "Pokémon Metal Psíquico");
            this.pokemons.Add(p);
            p = new Pokemon("Muk", "Pokémon Venenoso");
            this.pokemons.Add(p);
            p = new Pokemon("Giratina", "Pokémon Lendário");
            this.pokemons.Add(p);
        }

        //Método de Lista todos os pokémons
        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[i].ExibirDadosPokemon();
                //O comando de baixo faz a mesma função que o de cima.
                //Pokemon p = this.Pokemons[i];
                //p.ExibirDadosPokemon();
            }
        }
    }
}
