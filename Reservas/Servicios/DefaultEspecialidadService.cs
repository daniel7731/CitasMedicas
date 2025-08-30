using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public class DefaultEspecialidadService : IEspecialidadService
    {
        private readonly IEspecialidadStorage _storage;
        public DefaultEspecialidadService(IEspecialidadStorage storage)
        {
            _storage = storage;
        }
        public DefaultEspecialidadService()
        {
            _storage = new MemoryEspecialidadStorage();
        }
        public Especialidad ActualizarEspecialidad(Especialidad especialidad)
        {
           return _storage.Actualizar(especialidad);
        }

        public Especialidad GuardarEspecialidad(Especialidad especialidad)
        {
            return _storage.Guardar(especialidad);
        }

        public List<Especialidad> ListarEspecialidad()
        {
            return _storage.Listar();
        }

        public IEspecialidadStorage GetEspecialidadStorage()
        {
            throw new NotImplementedException();
        }
    }
}
