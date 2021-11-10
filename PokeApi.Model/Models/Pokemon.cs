using System;
using System.Collections.Generic;
using System.Text;
using static PokeApi.Services.IPokemonContext;

namespace PokeApi.Model.Models
{
    public class Pokemon
    {
        public int id { get; set; }
        public string name { get; set; }

        public string color { get; set; }

        public List<string> types { get; set; }
        public List<string> stats { get; set; }
        public List<string> abilities { get; set; }
        public List<string> moves { get; set; }

        public int weight { get; set; }
        public int height { get; set; }
        public List<string> sprite { get; set; }
    }
}
