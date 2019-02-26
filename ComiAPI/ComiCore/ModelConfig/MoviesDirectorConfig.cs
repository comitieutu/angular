using ComiCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.ModelConfig
{
    public class MoviesDirectorConfig : IEntityTypeConfiguration<MoviesDirector>
    {
        public void Configure(EntityTypeBuilder<MoviesDirector> builder)
        {
            builder.HasKey(md => new { md.DierctorId, md.MoviesId });
            builder.HasOne(md => md.Director)
                .WithMany(d => d.MoviesDirectors)
                .HasForeignKey(md => md.DierctorId);
            builder.HasOne(md => md.Movies)
                .WithMany(m => m.MoviesDirectors)
                .HasForeignKey(md => md.MoviesId);
        }
    }
}
