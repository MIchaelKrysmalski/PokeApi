using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApi.Model.Models
{
    public interface IRepository
    {
        public IUserRepository users { get; }

        public IPokemonRepository pokemons { get; }
    }
}
