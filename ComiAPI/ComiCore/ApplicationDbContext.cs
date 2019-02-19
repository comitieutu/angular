using System;
using System.Collections.Generic;
using System.Text;
using ComiCore.Model;
using Microsoft.EntityFrameworkCore;

namespace ComiCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
    }
}
