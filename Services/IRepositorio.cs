namespace API_EjercicioIntroduccionDatosOrdenadores.Services
{
    public interface IRepositorio
    {
        public interface IRepositorio<T>
        {
            IEnumerable<T> GetAll();
            T? Get(int id);
            void Create(T item);
            void Update(T item);
            void Delete(int id);
        }
    }
}
