using ComiCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.ModelConfig
{
    public class GenreMoviesConfig : IEntityTypeConfiguration<GenreMovies>
    {
        public void Configure(EntityTypeBuilder<GenreMovies> builder)
        {
            builder.HasKey(gm => new { gm.GenreId, gm.MoviesId});
            builder.HasOne(gm => gm.Genre)
                .WithMany(g => g.GenreMovies)
                .HasForeignKey(gm => gm.GenreId);
            builder.HasOne(gm => gm.Movies)
                .WithMany(g => g.GenresMovies)
                .HasForeignKey(gm => gm.MoviesId);
        }
    }
}
