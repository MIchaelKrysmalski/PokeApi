using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokeApi.Model.Models;
using static PokeApi.Services.IPokemonContext.Abilities;
using static PokeApi.Services.IPokemonContext.Stats;

namespace PokeApi.Services
{
    public class PokeDataHelper
    {
       
        public PokemonData fetchPokemonData(Pokemon pokemon)
        {
            PokemonData pokeData = new PokemonData();
            List<string> pokemonAbilities = new List<string>();
            List<int> stats = new List<int>();
            foreach(string element in pokemon.abilities)
            {
                pokemonAbilities.Add(element);
            }
            foreach (string element in pokemon.stats)
            {
                var pokemonStat = element.Split(",");
                stats.Add(Convert.ToInt32(pokemonStat[1]));
            }
            switch (pokemon.color) 
            {
                case "red":
                    pokeData.color = "rgba(255,0,0,0.4)";
                    break;
                case "green":
                    pokeData.color = "rgba(0,128,0,0.4)";
                    break;
                case "blue":
                    pokeData.color = "rgba(0,0,255,0.4)";
                    break;
                case "white":
                    pokeData.color = "rgba(248,248,255,0.4)";
                    break;
                case "brown":
                    pokeData.color = "rgba(165,42,42,0.4)";
                    break;
                case "purple":
                    pokeData.color = "rgba(128,0,128,0.4)";
                    break;
                case "yellow":
                    pokeData.color = "rgba(255,255,0,0.4)";
                    break;
                case "pink":
                    pokeData.color = "rgba(255,192,203,0.4)";
                    break;
                case "gray":
                    pokeData.color = "rgba(128,128,128,0.4)";
                    break;
                case "black":
                    pokeData.color = "rgba(0,0,0,0.4)";
                    break;
                default:
                    pokeData.color = "black";
                    break;
            }
            pokeData.id = pokemon.id;
            pokeData.name = pokemon.name;
            pokeData.hp = stats[0];
            pokeData.attack = stats[1];
            pokeData.defense = stats[2];
            pokeData.special_attack = stats[3];
            pokeData.special_defence = stats[4];
            pokeData.speed = stats[5];
            pokeData.weight = pokemon.weight;
            pokeData.height = pokemon.height;
            pokeData.sprites = pokemon.sprite;
            pokeData.abilities = pokemonAbilities;
            pokeData.types = string.Join(",", pokemon.types);
            pokeData.moves = pokemon.moves;
            return pokeData;
        }
        public List<PokemonData> fetchPokemonsData(List<Pokemon> pokemons)
        {
            List<PokemonData> pokemonData = new List<PokemonData>();
            foreach(Pokemon pokemon in pokemons)
            {
                PokemonData pokeData = fetchPokemonData(pokemon);
                pokemonData.Add(pokeData);
            }
            return pokemonData;
        }
}
}
