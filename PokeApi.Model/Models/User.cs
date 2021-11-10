using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApi.Model.Models
{
    public class User
    {
        public int id { get; set; }

        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<int> pokemons { get; set; }
    }
}
