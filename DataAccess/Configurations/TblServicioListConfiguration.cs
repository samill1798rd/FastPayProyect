using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.FastPayModel;

namespace DataAccess.Configurations
{
    public class TblServicioListConfiguration : IEntityTypeConfiguration<TblServicioList>
    {
        public void Configure(EntityTypeBuilder<TblServicioList> builder)
        {
            builder.HasKey(e => e.IdServicioList)
                   .HasName("PK__Tbl_serv__BC58685D810BD916");

            builder.ToTable("Tbl_servicioList");

            builder.Property(e => e.IdServicioList).HasColumnName("Id_servicioList");

            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ServicioHeaderId).HasColumnName("ServicioHeader_Id");

            builder.HasOne(d => d.ServicioHeader)
                .WithMany(p => p.TblServicioList)
                .HasForeignKey(d => d.ServicioHeaderId)
                .HasConstraintName("FK__Tbl_servi__Servi__403A8C7D");
        }
    }
}
