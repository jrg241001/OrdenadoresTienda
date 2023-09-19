using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EjercicioIntroduccionBBDDFirst;

public partial class EjercicioIntroduccionDatosOrdenadoresDataContext : DbContext
{
    public EjercicioIntroduccionDatosOrdenadoresDataContext()
    {
    }

    public EjercicioIntroduccionDatosOrdenadoresDataContext(DbContextOptions<EjercicioIntroduccionDatosOrdenadoresDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Componente> Componentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EjercicioIntroduccionDatosOrdenadores.Data;Trusted_Connection=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Componente>(entity =>
        {
            entity.ToTable("componentes");

            entity.Property(e => e.Nserie).HasColumnName("NSerie");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
