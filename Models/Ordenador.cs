using EjercicioIntroduccionDatosOrdenadores.Models;
using System.ComponentModel.DataAnnotations;

namespace API_EjercicioIntroduccionDatosOrdenadores.Models
{
    public class Ordenador
    {
        public partial class Ordenadores
        {
            [ScaffoldColumn(false)]

            public int Id { get; set; }
            public string nombre { get; set; }
            public virtual ICollection<Componentes> damePartes { get; set; }

        }
    }
}
