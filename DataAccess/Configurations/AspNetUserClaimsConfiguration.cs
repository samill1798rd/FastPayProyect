using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.FastPayModel;

namespace DataAccess.Configurations
{
    public class AspNetUserClaimsConfiguration : IEntityTypeConfiguration<AspNetUserClaims>
    {
        public void Configure(EntityTypeBuilder<AspNetUserClaims> builder)
        {
            builder.HasIndex(e => e.UserId);

            builder.Property(e => e.UserId).IsRequired();

            builder.HasOne(d => d.User)
                .WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId);
        }
    }
}
