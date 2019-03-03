using System;
using System.Collections.Generic;
using System.Text;
using ComiCore.Model;
using ComiCore.ModelConfig;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ComiCore
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>,
                                            ApplicationUserRole, IdentityUserLogin<string>,
                                            IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GenreMoviesConfig());
            modelBuilder.ApplyConfiguration(new MoviesActorConfig());
            modelBuilder.ApplyConfiguration(new MoviesDirectorConfig());
        }
    }
}
