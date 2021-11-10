using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PokeApi.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using static PokeApi.Services.IPokemonContext;
using static PokeApi.Services.IPokemonContext.Stats;

namespace PokeApi.Services
{
    public class HttpService : Controller
    {
        private ILogger logger;
        static HttpClient client = new HttpClient();
        private IRepository repository;
        public HttpService(ILogger<HttpService> logger, IRepository repository)
        {
            this.repository = repository;
            this.logger = logger;
        }
        public async Task GetPokemons()
        {
            HttpResponseMessage pokemonUrls = await client.GetAsync("https://pokeapi.co/api/v2/pokemon?limit=151");
            if (pokemonUrls.IsSuccessStatusCode)
            {
                var pokemonUrlsData = await pokemonUrls.Content.ReadAsStringAsync();
                IPokemonUrls pokemonUrlsResult = JsonConvert.DeserializeObject<IPokemonUrls>(pokemonUrlsData);
                for (int i = 0; i < pokemonUrlsResult.results.Length; i++)
                {
                    HttpResponseMessage pokemonContext = await client.GetAsync(pokemonUrlsResult.results[i].url);
                    if (pokemonContext.IsSuccessStatusCode)
                    {
                        var PokemonContextData = await pokemonContext.Content.ReadAsStringAsync();
                        IPokemonContext PokemonContextResult = JsonConvert.DeserializeObject<IPokemonContext>(PokemonContextData);
                        HttpResponseMessage pokemonColor = await client.GetAsync(PokemonContextResult.species.url);
                        if (pokemonColor.IsSuccessStatusCode)
                        {
                            var pokemonColorData = await pokemonColor.Content.ReadAsStringAsync();
                            IPokemonColor pokemonColorResult = JsonConvert.DeserializeObject<IPokemonColor>(pokemonColorData);

                            List<string> pokemonTypes = new List<string>();
                            List<string> pokemonStats = new List<string>();
                            List<string> pokemonAbilities = new List<string>();
                            List<string> pokemonMoves = new List<string>();
                            List<string> pokemonSprites = new List<string>();
                            for (int j = 0; j <PokemonContextResult.types.Length; j++)
                            {
                                pokemonTypes.Add(PokemonContextResult.types[j].type.name);
                            }
                            for (int j = 0; j < PokemonContextResult.stats.Length; j++)
                            {
                                pokemonStats.Add(PokemonContextResult.stats[j].stat.name+","+PokemonContextResult.stats[j].base_stat);
                            }
                            for (int j = 0; j < PokemonContextResult.abilities.Length; j++)
                            {
                                pokemonAbilities.Add(PokemonContextResult.abilities[j].ability.name);
                            }
                            for (int j = 0; j < PokemonContextResult.moves.Length; j++)
                            {
                                pokemonMoves.Add(PokemonContextResult.moves[j].move.name);
                            }
                                pokemonSprites.Add(PokemonContextResult.sprites.front_default);
                                pokemonSprites.Add(PokemonContextResult.sprites.back_default);
                                pokemonSprites.Add(PokemonContextResult.sprites.front_shiny);
                                pokemonSprites.Add(PokemonContextResult.sprites.back_shiny);
                            

                            Pokemon pokemon = new Pokemon() {
                                id = 0,
                                name = PokemonContextResult.name,
                                color = pokemonColorResult.color.name,
                                types = pokemonTypes,
                                stats = pokemonStats,
                                abilities = pokemonAbilities,
                                moves = pokemonMoves,
                                weight = PokemonContextResult.weight,
                                height = PokemonContextResult.height,
                                sprite = pokemonSprites
                            };
                            this.repository.pokemons.create(pokemon);
                        }
                    }
                }
            }
            
            

        }
    }
}
