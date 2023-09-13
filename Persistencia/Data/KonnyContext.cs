using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;

    public class KonnyContext : DbContext
    {
        public KonnyContext(DbContextOptions<KonnyContext> options) : base(options)
        {}
       // public DbSet<NombreDeLaClaseDeLaEntidadSINGULAR> NombreDeLaClaseDeLaEntidadPLURAL { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Pais>().HasIndex(idx => idx.NombrePais).IsUnique();   estas dos lineas de codigo son para que estas configuraciones sean unicas
            //modelBuilder.Entity<TrainerSalon>().HasKey(r => new { r.IdPerTrainerFk, r.IdSalonFk});
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

