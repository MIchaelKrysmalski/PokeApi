using PokeApi.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.EF
{
    public class EfRepository : IRepository, IDisposable
    {
        private PokeApiContext context;
        private IUserRepository userRepository;
        private IPokemonRepository pokemonRepository;

        public EfRepository()
        {
            context = new PokeApiContext();
            userRepository = new EfUserRepository(context);
            pokemonRepository = new EfPokemonRepository(context);
        }
       public void Dispose()
       {
           context.Dispose();
       }
        public IPokemonRepository pokemons
        {
            get { return pokemonRepository; }
        }
        public IUserRepository users
        {
            get { return userRepository; }
        }
    }
}
