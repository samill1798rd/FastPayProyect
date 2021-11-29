using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.FastPayModel;

namespace DataAccess.Configurations
{
    public class AspNetUsersConfiguration : IEntityTypeConfiguration<AspNetUsers>
    {
        public void Configure(EntityTypeBuilder<AspNetUsers> builder)
        {
            builder.HasIndex(e => e.NormalizedEmail)
                   .HasName("EmailIndex");

            builder.HasIndex(e => e.NormalizedUserName)
                .HasName("UserNameIndex")
                .IsUnique();

            builder.Property(e => e.Apellido).HasMaxLength(100);

            builder.Property(e => e.Cedula).HasMaxLength(20);

            builder.Property(e => e.Email).HasMaxLength(256);

            builder.Property(e => e.FechaNacimiento).HasColumnType("datetime");

            builder.Property(e => e.NoCuenta).HasMaxLength(20);

            builder.Property(e => e.Nombre).HasMaxLength(100);

            builder.Property(e => e.NormalizedEmail).HasMaxLength(256);

            builder.Property(e => e.NormalizedUserName).HasMaxLength(256);

            builder.Property(e => e.Sexo).HasMaxLength(20);

            builder.Property(e => e.UserName).HasMaxLength(256);
        }
    }
}
