using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApi.Model.Models
{
    public interface IPokemonRepository
    {
        int create(Pokemon pokemon);
        List<Pokemon> getAll();

        Pokemon getById(int id);

        int count();
    }
}
