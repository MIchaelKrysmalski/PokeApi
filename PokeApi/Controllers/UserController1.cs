using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeApi.Model.Models;
using PokeApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Controllers
{
    public class UserController : Controller
    {
        private IRepository repository;
        private PokeDataHelper helper;

        public UserController(IRepository repository,PokeDataHelper helper)
        {
            this.helper = helper;
            this.repository = repository;
        }
        public IActionResult Index()
        {
            List<PokemonData> pokeData = new List<PokemonData>();
            var userId = -1;
            if (HttpContext.Session.GetInt32("userId").HasValue)
            userId = HttpContext.Session.GetInt32("userId").Value;
            var user = repository.users.getById(userId);
            if(user != null)
            foreach(int id in user.pokemons)
            {
                Pokemon pokemon = repository.pokemons.getById(id);
                PokemonData data = helper.fetchPokemonData(pokemon);
                pokeData.Add(data);
            }
            return View(pokeData);
        }
        public IActionResult addPokemon(int id)
        {
            var user = HttpContext.Session.GetInt32("userId").Value;
            repository.users.updatePokemonCollection(user, id);
            return Redirect("/user/index");
        }
        public IActionResult removePokemon(int id)
        {
            var user = HttpContext.Session.GetInt32("userId").Value;
            repository.users.removeFromPokemonCollection(user, id);
            return Redirect("/user/index");
        }
        public IActionResult UserPokemonCollection()
        {
            List<UserPokemonData> userData = new List<UserPokemonData>();
            var loggedInUser = HttpContext.Session.GetInt32("userId").Value;
            var users = repository.users.getAllUsers();
            users = users.FindAll(u => u.id != loggedInUser);
            foreach(User user in users)
            {
                List<PokemonData> pokemons = new List<PokemonData>();
                foreach(int id in user.pokemons)
                {
                    Pokemon pokemon = repository.pokemons.getById(id);
                    pokemons.Add(helper.fetchPokemonData(pokemon));
                }
                userData.Add(new UserPokemonData()
                {
                    id = user.id,
                    username = user.username,
                    pokemons = pokemons
                }) ;
            }
            return View(userData);
        }
    }
}
