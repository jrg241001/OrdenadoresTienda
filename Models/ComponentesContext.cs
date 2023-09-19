using Microsoft.EntityFrameworkCore;

namespace API_EjercicioIntroduccionDatosOrdenadores.Models
{
    public class ComponentesContext : DbContext
    {
        public ComponentesContext(DbContextOptions<ComponentesContext> options)
           : base(options)
        {
        }

        public DbSet<Componentes> Componentes { get; set; } = null!;
    }
}
