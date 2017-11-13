using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RorasCargoExercise.Entities;

namespace RorasCargoExercise.Migrations
{
    [DbContext(typeof(RocketContext))]
    partial class RocketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RorasCargoExercise.Models.Rocket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Caliber");

                    b.Property<bool>("Ready");

                    b.HasKey("Id");

                    b.ToTable("Rockets");
                });
        }
    }
}
