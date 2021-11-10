using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApi.Model.Models
{
    public interface IUserRepository
    {
        List<User> getAllUsers();
        User getById(int id);
        User getByUsernameAndPassword(LoginModel login);
        int updatePokemonCollection(int userid, int pokemonId);
        int removeFromPokemonCollection(int userid, int pokemonId);
        int create(User user);

    }
}
