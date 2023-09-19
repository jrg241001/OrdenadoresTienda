using System.ComponentModel.DataAnnotations;

namespace API_EjercicioIntroduccionDatosOrdenadores.Models
{
    public class Componentes
    {
        

            [ScaffoldColumn(false)]
            public int Id { get; set; }

            public string Descripcion { get; set; }
            public string NSerie { get; set; }
            public double Precio { get; set; }
            public int Cores { get; set; }
            public double Grados { get; set; }
            public int Almacenamiento { get; set; }
            public string TipoComponente { get; set; }

            public int? OrdenadoresId { get; set; }

        
    }
}
