// <auto-generated />
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PokeApi.EF;

namespace PokeApi.EF.Migrations
{
    [DbContext(typeof(PokeApiContext))]
    partial class PokeApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PokeApi.Model.Models.Pokemon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<List<string>>("abilities")
                        .HasColumnType("text[]");

                    b.Property<string>("color")
                        .HasColumnType("text");

                    b.Property<int>("height")
                        .HasColumnType("integer");

                    b.Property<List<string>>("moves")
                        .HasColumnType("text[]");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<List<string>>("sprite")
                        .HasColumnType("text[]");

                    b.Property<List<string>>("stats")
                        .HasColumnType("text[]");

                    b.Property<List<string>>("types")
                        .HasColumnType("text[]");

                    b.Property<int>("weight")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("pokemons");
                });

            modelBuilder.Entity("PokeApi.Model.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<List<int>>("pokemons")
                        .HasColumnType("integer[]");

                    b.Property<string>("username")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
