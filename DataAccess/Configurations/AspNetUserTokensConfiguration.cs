﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.FastPayModel;

namespace DataAccess.Configurations
{
    public class AspNetUserTokensConfiguration : IEntityTypeConfiguration<AspNetUserTokens>
    {
        public void Configure(EntityTypeBuilder<AspNetUserTokens> builder)
        {
            builder.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            builder.Property(e => e.LoginProvider).HasMaxLength(128);

            builder.Property(e => e.Name).HasMaxLength(128);

            builder.HasOne(d => d.User)
                .WithMany(p => p.AspNetUserTokens)
                .HasForeignKey(d => d.UserId);
        }
    }
}
