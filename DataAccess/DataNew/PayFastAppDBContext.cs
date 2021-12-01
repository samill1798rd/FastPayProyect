using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Model.FastPayModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataAccess.DataNew
{
    public partial class PayFastAppDBContext : DbContext
    {
        public PayFastAppDBContext()
        {
        }

        public PayFastAppDBContext(DbContextOptions<PayFastAppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<TblHistoricoTrasaciones> TblHistoricoTrasaciones { get; set; }
        public virtual DbSet<TblServicioList> TblServicioList { get; set; }
        public virtual DbSet<TblServicioNameCabezera> TblServicioNameCabezera { get; set; }
        public virtual DbSet<TblServicoList> TblServicoList { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("server=DESKTOP-7PO5S2D\\SQLEXPRESS;Database=PayFastAppDB;Integrated Security=true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Apellido).HasMaxLength(100);

                entity.Property(e => e.Cedula).HasMaxLength(20);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.NoCuenta).HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.Sexo).HasMaxLength(20);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<TblHistoricoTrasaciones>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoTransaciones)
                    .HasName("PK__Tbl_Hist__226633F7E2D2F671");

                entity.ToTable("Tbl_HistoricoTrasaciones");

                entity.Property(e => e.IdHistoricoTransaciones).HasColumnName("Id_HistoricoTransaciones");

                entity.Property(e => e.CedulaUser)
                    .HasColumnName("cedulaUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PorcientoPagina)
                    .HasColumnName("porcientoPagina")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenciaPago)
                  .HasColumnName("ReferenciaPago")
                  .HasMaxLength(50)
                  .IsUnicode(false);

                entity.Property(e => e.ServicioHeaderId).HasColumnName("ServicioHeader_Id");

                entity.Property(e => e.ServicioListId).HasColumnName("servicioList_id");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ServicioHeader)
                    .WithMany(p => p.TblHistoricoTrasaciones)
                    .HasForeignKey(d => d.ServicioHeaderId)
                    .HasConstraintName("FK__Tbl_Histo__Servi__47DBAE45");

                //entity.HasOne(d => d.ServicioList)
                //    .WithMany(p => p.TblHistoricoTrasaciones)
                //    .HasForeignKey(d => d.ServicioListId)
                //    .HasConstraintName("FK__Tbl_Histo__servi__48CFD27E");
            });

            modelBuilder.Entity<TblServicioList>(entity =>
            {
                entity.HasKey(e => e.IdServicioList)
                    .HasName("PK__Tbl_serv__BC58685D810BD916");

                entity.ToTable("Tbl_servicioList");

                entity.Property(e => e.IdServicioList).HasColumnName("Id_servicioList");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicioHeaderId).HasColumnName("ServicioHeader_Id");

                entity.HasOne(d => d.ServicioHeader)
                    .WithMany(p => p.TblServicioList)
                    .HasForeignKey(d => d.ServicioHeaderId)
                    .HasConstraintName("FK__Tbl_servi__Servi__403A8C7D");
            });

            modelBuilder.Entity<TblServicioNameCabezera>(entity =>
            {
                entity.HasKey(e => e.IdServicioHeader)
                    .HasName("PK__Tbl_Serv__6A97F2C9CD84105C");

                entity.ToTable("Tbl_ServicioNameCabezera");

                entity.Property(e => e.IdServicioHeader).HasColumnName("Id_ServicioHeader");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblServicoList>(entity =>
            {
                entity.HasKey(e => e.IdServicoList)
                    .HasName("PK__Tbl_serv__AD6B8ADFB2457357");

                entity.ToTable("Tbl_servicoList");

                entity.Property(e => e.IdServicoList).HasColumnName("Id_servicoList");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicioHeaderId).HasColumnName("ServicioHeader_Id");

                entity.HasOne(d => d.ServicioHeader)
                    .WithMany(p => p.TblServicoList)
                    .HasForeignKey(d => d.ServicioHeaderId)
                    .HasConstraintName("FK__Tbl_servi__Servi__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
