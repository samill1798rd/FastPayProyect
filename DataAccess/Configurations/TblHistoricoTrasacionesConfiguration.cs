using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.FastPayModel;

namespace DataAccess.Configurations
{
    public class TblHistoricoTrasacionesConfiguration : IEntityTypeConfiguration<TblHistoricoTrasaciones>
    {
        public void Configure(EntityTypeBuilder<TblHistoricoTrasaciones> builder)
        {
            builder.HasKey(e => e.IdHistoricoTransaciones)
                    .HasName("PK__Tbl_Hist__226633F7E2D2F671");

            builder.ToTable("Tbl_HistoricoTrasaciones");

            builder.Property(e => e.IdHistoricoTransaciones).HasColumnName("Id_HistoricoTransaciones");

            builder.Property(e => e.CedulaUser)
                .HasColumnName("cedulaUser")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Monto)
                .HasColumnName("monto")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.PorcientoPagina)
                .HasColumnName("porcientoPagina")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ServicioHeaderId).HasColumnName("ServicioHeader_Id");

            builder.Property(e => e.ServicioListId).HasColumnName("servicioList_id");

            builder.Property(e => e.Total)
                .HasColumnName("total")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.ServicioHeader)
                .WithMany(p => p.TblHistoricoTrasaciones)
                .HasForeignKey(d => d.ServicioHeaderId)
                .HasConstraintName("FK__Tbl_Histo__Servi__47DBAE45");

            builder.HasOne(d => d.ServicioList)
                .WithMany(p => p.TblHistoricoTrasaciones)
                .HasForeignKey(d => d.ServicioListId)
                .HasConstraintName("FK__Tbl_Histo__servi__48CFD27E");
        }
    }
}
