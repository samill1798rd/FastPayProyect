﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.FastPayModel;

namespace DataAccess.Configurations
{
    public class AspNetUserLoginsConfiguration : IEntityTypeConfiguration<AspNetUserLogins>
    {
        public void Configure(EntityTypeBuilder<AspNetUserLogins> builder)
        {

            builder.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            builder.HasIndex(e => e.UserId);

            builder.Property(e => e.LoginProvider).HasMaxLength(128);

            builder.Property(e => e.ProviderKey).HasMaxLength(128);

            builder.Property(e => e.UserId).IsRequired();

            builder.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);

        }
    }
}
