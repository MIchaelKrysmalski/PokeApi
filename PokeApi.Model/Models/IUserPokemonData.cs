using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApi.Model.Models
{
    public class UserPokemonData
    {
        public int id { get; set; }
        public string username { get; set; }
        public List<PokemonData> pokemons { get; set; }
    }
}
