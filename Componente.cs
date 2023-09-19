using System;
using System.Collections.Generic;

namespace EjercicioIntroduccionBBDDFirst;

public partial class Componente
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Nserie { get; set; } = null!;

    public double Precio { get; set; }

    public int Cores { get; set; }

    public double Grados { get; set; }

    public int Almacenamiento { get; set; }

    public string TipoComponente { get; set; } = null!;
}
