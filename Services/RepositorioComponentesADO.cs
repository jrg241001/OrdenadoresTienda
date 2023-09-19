
using API_EjercicioIntroduccionDatosOrdenadores.Models;
using Microsoft.Data.SqlClient;
using static API_EjercicioIntroduccionDatosOrdenadores.Services.IRepositorio;

namespace API_EjercicioIntroduccionDatosOrdenadores.Services
{
    public class RepositorioComponentesADO : IRepositorio<Componentes>
    {
        private readonly ADOContext _context;

        public RepositorioComponentesADO(ADOContext context)
        {
            _context = context;
        }

        public IEnumerable<Componentes> GetAll()
        {
            var conexion = _context.GetConnection();
            var componentes = new List<Componentes>();
            string sql = "Select * From Componente";

            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();

            // Obtain a data reader via ExecuteReader().
            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                // Loop over the results
                while (dataReader.Read())
                {
                    int componenteId = Convert.ToInt32(dataReader["Id"]);

                    string componenteName = Convert.ToString(dataReader["NumeroSerie"]);
                    double componentePrice = Convert.ToDouble(dataReader["Precio"]);
                    int ComponenteAlmacenamiento = Convert.ToInt16(dataReader["Almacenamiento"]);
                    int ComponenteCores = Convert.ToInt16(dataReader["Almacenamiento"]);
                    string ComponenteDescripcion = Convert.ToString(dataReader["Descripcion"]);
                    int ComponenteGrados = Convert.ToInt16(dataReader["Grados"]);
                    int ComponenteOrdenadoresId = Convert.ToInt16(dataReader["OrdenadoresId"]);
                    string ComponenteTipoComponente = Convert.ToString(dataReader["TipoComponente"]);

                    componentes.Add(new Componentes() { Id = componenteId, NSerie = componenteName, Precio = componentePrice,Almacenamiento = ComponenteAlmacenamiento,Cores = ComponenteCores ,
                        Descripcion = ComponenteDescripcion,Grados = ComponenteGrados,OrdenadoresId = ComponenteOrdenadoresId,TipoComponente = ComponenteTipoComponente});
                }

            }

            conexion.Close();
            return componentes;
        }

        public Componentes? Get(int id)
        {
            var conexion = _context.GetConnection();

            var sql = "SELECT * FROM Componente WHERE Id == " + id;
            var command = new SqlCommand(sql, conexion);

            conexion.Open();

            conexion.Close();

            return new();
        }

        public void Create(Componentes item)
        {
            /*item.Id = componentes.Count() + 1;
            componentes.Add(item);*/
        }

        public void Update(Componentes item)
        {
            /*var indexComponente = componentes.FindIndex(c => c.Id == item.Id);

            if (indexComponente == -1) return;

            componentes[indexComponente] = item;*/
        }

        public void Delete(int id)
        {
            /*var indexComponente = componentes.FindIndex(c => c.Id == id);

            if (indexComponente == -1) return;
            
            componentes.RemoveAt(indexComponente);*/
        }
    }
}
