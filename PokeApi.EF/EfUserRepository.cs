using Microsoft.EntityFrameworkCore;
using PokeApi.Model.Models;
using SimpleHashing.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.EF
{
    public class EfUserRepository : IUserRepository
    {
        private PokeApiContext context;
        private ISimpleHash simpleHash = new SimpleHash();
        public EfUserRepository(PokeApiContext context)
        {
            this.context = context;
            //this.create(new User() { email = "m.krysmalski@outlook.de", password = "admin", username = "hotsweetchilli",pokemons=new List<int>() });
        } 
        public List<User> getAllUsers()
        {
            return context.users.ToList();
        }
        public User getById(int id)
        {
            return (from user in context.users where user.id == id select user).AsNoTracking().SingleOrDefault();
        }
        public int updatePokemonCollection(int userid,int pokemonId)
        {
            var entity = context.users.FirstOrDefault(user => user.id == userid);
            if (entity.pokemons.IndexOf(pokemonId) == -1)
            {
                entity.pokemons.Add(pokemonId);
                context.SaveChanges();
            }
            return 1;
        }
        public int removeFromPokemonCollection(int userId, int pokemonId)
        {
            var entity = context.users.FirstOrDefault(user => user.id == userId);
            if (entity.pokemons.IndexOf(pokemonId) != -1)
            {
                entity.pokemons.Remove(pokemonId);
                context.SaveChanges();
            }
            return 1;
        }
        public User getByUsernameAndPassword(LoginModel login)
        {
            var list = (from user in context.users
                        where user.username.Equals(login.Username)
                        select user).ToList();
            foreach(var user in list)
            {
                if (simpleHash.Verify(login.Password, user.password))
                    return user;
            }
            return null;
        }
        public int create(User user)
        {
            if(user.id == 0)
            {
                user.password = simpleHash.Compute(user.password);
                context.users.Add(user);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
