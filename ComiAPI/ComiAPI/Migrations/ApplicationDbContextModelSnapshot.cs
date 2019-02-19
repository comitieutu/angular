﻿// <auto-generated />
using System;
using ComiCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComiAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComiCore.Model.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("MoviesId");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.HasIndex("MoviesId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ComiCore.Model.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("ComiCore.Model.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description");

                    b.Property<int>("Episode");

                    b.Property<DateTime>("Manufacture");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<string>("Status");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("ComiCore.Model.Trailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("MoviesId");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.HasIndex("MoviesId");

                    b.ToTable("Trailers");
                });

            modelBuilder.Entity("ComiCore.Model.Comment", b =>
                {
                    b.HasOne("ComiCore.Model.Movies", "Movies")
                        .WithMany("Comments")
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComiCore.Model.Trailer", b =>
                {
                    b.HasOne("ComiCore.Model.Movies", "Movies")
                        .WithMany("Trailers")
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
