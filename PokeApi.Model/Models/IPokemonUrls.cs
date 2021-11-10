using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Services
{
    public class IPokemonUrls
    {
        public Result[] results;
        public class Result
        {
            public string name;
            public string url;
        }
    }
}
