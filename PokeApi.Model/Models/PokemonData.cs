using System;
using System.Collections.Generic;
using System.Text;
using static PokeApi.Services.IPokemonContext.Stats;

namespace PokeApi.Model.Models
{
    public class PokemonData
    {
        public int id;
        public string name;
        public string color;
        public int weight;
        public int height;
        public int hp;
        public int attack;
        public int defense;
        public int special_attack;
        public int special_defence;
        public int speed;
        public List<string> sprites;
        public string types;
        public List<string> abilities;
        public List<string> moves;

    }
}
