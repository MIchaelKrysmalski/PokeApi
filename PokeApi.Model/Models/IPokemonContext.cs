using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Services
{
    public class IPokemonContext
    {
        public string name;
        public int weight;
        public int height;
        public Type[] types;
        public Stats[] stats;
        public Sprite sprites;
        public Abilities[] abilities;
        public Species species;
        public int base_experience;
        public Moves[] moves;
        
        public class Species
        {
            public string url;
        }
        public class Moves
        {
            public Move move;
            public class Move
            {
                public string name;
            }
        }

        public class Abilities
        {
            public Ability ability;
            public class Ability
            {
                public string name;
            }
        }

        public class Sprite
        {
            public string back_default;
            public string front_default;
            public string back_shiny;
            public string front_shiny;

        }

        public class Stats
        {
            public int base_stat;
            public Stat stat;
            public class Stat
            {
                public string name;
            }
        }

        public class Type
        {
            public TypeElement type;
            public class TypeElement
            {
                public string name;
            }
        }
    }
}
