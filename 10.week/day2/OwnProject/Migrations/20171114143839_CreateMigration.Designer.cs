using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OwnProject.Entities;

namespace OwnProject.Migrations
{
    [DbContext(typeof(SongContext))]
    [Migration("20171114143839_CreateMigration")]
    partial class CreateMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OwnProject.Models.Artist", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long>("SongId");

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("OwnProject.Models.Song", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Album");

                    b.Property<long>("Artist");

                    b.Property<int>("Date");

                    b.Property<string>("Genre");

                    b.HasKey("Id");

                    b.ToTable("Songs");
                });
        }
    }
}
