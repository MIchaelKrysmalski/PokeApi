using PokeApi.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.EF
{
    public class EfPokemonRepository : IPokemonRepository
    {
        private PokeApiContext context;
        public EfPokemonRepository(PokeApiContext context)
        {
            this.context = context;
        }
        public int create(Pokemon pokemon)
        {
            var pokecheck = context.pokemons.Where(x => x.name == pokemon.name).FirstOrDefault();
            if(pokecheck != null)
            {
                context.SaveChanges();
                return -1;
            }
            else
            {
                context.pokemons.Add(pokemon);
                context.SaveChanges();
                return 1;
            }
        }
        public Pokemon getById(int id)
        {
            var pokemon = context.pokemons.Where(x => x.id == id).FirstOrDefault();
            return pokemon;
        }
        public List<Pokemon> getAll()
        {
            var result = context.pokemons.ToList<Pokemon>();
            return result;
        }
        public int count()
        {
            return context.pokemons.Count();
        }

    }
}
