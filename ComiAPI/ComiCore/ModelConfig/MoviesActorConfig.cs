using ComiCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore.ModelConfig
{
    public class MoviesActorConfig : IEntityTypeConfiguration<MoviesActor>
    {
        public void Configure(EntityTypeBuilder<MoviesActor> builder)
        {
            builder.HasKey(ma => new { ma.ActorId , ma.MoviesId });
            builder.HasOne(ma => ma.Actor)
                .WithMany(a => a.MoviesActors)
                .HasForeignKey(ma => ma.ActorId);
            builder.HasOne(ma => ma.Movies)
                .WithMany(m => m.MoviesActors)
                .HasForeignKey(ma => ma.MoviesId);
        }
    }
}
