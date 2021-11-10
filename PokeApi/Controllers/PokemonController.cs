using Microsoft.AspNetCore.Mvc;
using PokeApi.Model.Models;
using PokeApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PokeApi.Controllers
{
    public class PokemonController : Controller
    {
        private HttpService service;
        private IRepository repository;
        private PokeDataHelper helper;

        public PokemonController(HttpService service, IRepository repository, PokeDataHelper helper)
        {
            this.helper = helper;
            this.repository = repository;
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pokedex()
        {
            var pokemons = repository.pokemons.getAll();
            List<PokemonData> pokemonData = helper.fetchPokemonsData(pokemons);
            return View(pokemonData);
        }
        public IActionResult RandomPokemon()
        {
            Random random = new Random();
            var pokemons = repository.pokemons.getAll();
            var randomPokemon = pokemons[random.Next(pokemons.Count)];
            PokemonData pokemonData = helper.fetchPokemonData(randomPokemon);
            return View(pokemonData);
        }
        public async Task<IActionResult> LoadPokemonData()
        {
            await service.GetPokemons();
            return Redirect("/User");
        }

        public IActionResult ById(string id)
        {
            Pokemon pokemon = new Pokemon();
            PokemonData pokemonData = new PokemonData();
            if (id != null)
            {
                int pokeId = Convert.ToInt32(id);
                pokemon = this.repository.pokemons.getById(pokeId);
                pokemonData = helper.fetchPokemonData(pokemon);
            }
            return View(pokemonData);
        }
    }
}
