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
    public class AuthenticationController : Controller
    {
        private IRepository repository;
        private HttpService service;
        public AuthenticationController(IRepository repository, HttpService service)
        {
            this.service = service;
            this.repository = repository;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userId");
            return Redirect("/Authentication/Login");
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult CreateNewUser([FromForm] RegisterModel register)
        {
            List<int> pokemons = new List<int>();
            User user = new User()
            {
                email = register.Email,
                username = register.Username,
                password = register.Password,
                id = 0,
                pokemons = pokemons
            };
            var result = this.repository.users.create(user);
            return Redirect("/Authentication/Login");
        }
        public async Task<IActionResult> CheckUserCredentials([FromForm] LoginModel login)
        {
            var user = repository.users.getByUsernameAndPassword(login);
            if (user != null)
            {
                HttpContext.Session.SetInt32("userId", user.id);
                //If user is sucessfully logged in for the first time, the Pokemondata is loaded from the PokeApi
                if(repository.pokemons.count() == 0)
                {
                    await service.GetPokemons();
                }
                return Redirect("/User");
            }
            else
            {
                ModelState.AddModelError("", "User not found");
                return View("Login", login);
            }
            
        }
    }
}
