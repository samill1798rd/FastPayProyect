using DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;
using Model.FastPayModel;

namespace DataAccess.Data
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AspNetRoleClaimsConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetRolesConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUserClaimsConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUserLoginsConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUserRolesConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUsersConfiguration());
            modelBuilder.ApplyConfiguration(new AspNetUserTokensConfiguration());
            modelBuilder.ApplyConfiguration(new TblHistoricoTrasacionesConfiguration());
            modelBuilder.ApplyConfiguration(new TblServicioListConfiguration());
            modelBuilder.ApplyConfiguration(new TblServicioNameCabezeraConfiguration());

            //OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
