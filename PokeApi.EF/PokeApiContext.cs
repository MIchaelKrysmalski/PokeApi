using Microsoft.EntityFrameworkCore;
using PokeApi.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.EF
{
    public class PokeApiContext : DbContext
    {
        public DbSet<Pokemon> pokemons { get; set; }
        public DbSet<User> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Pokemon>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=host.docker.internal;Username=root;Password=root;Database=postgres";
            optionsBuilder.UseNpgsql(connectionString);
            
        }
    }
}
