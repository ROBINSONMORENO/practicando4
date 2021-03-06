// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using apppracticando.Models;

namespace apppracticando.Migrations
{
    [DbContext(typeof(apppracticandoContext))]
    partial class apppracticandoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("apppracticando.Models.Fails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Foto")
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .HasColumnType("text");

                    b.Property<string>("Usuario")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Failss");
                });
#pragma warning restore 612, 618
        }
    }
}
