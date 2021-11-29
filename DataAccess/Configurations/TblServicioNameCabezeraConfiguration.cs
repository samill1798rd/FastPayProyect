using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.FastPayModel;

namespace DataAccess.Configurations
{
    public class TblServicioNameCabezeraConfiguration : IEntityTypeConfiguration<TblServicioNameCabezera>
    {
        public void Configure(EntityTypeBuilder<TblServicioNameCabezera> builder)
        {
            builder.HasKey(e => e.IdServicioHeader)
              .HasName("PK__Tbl_Serv__6A97F2C9CD84105C");

            builder.ToTable("Tbl_ServicioNameCabezera");

            builder.Property(e => e.IdServicioHeader).HasColumnName("Id_ServicioHeader");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
