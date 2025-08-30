using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public interface IEspecialidadService
    {
        protected IEspecialidadStorage GetEspecialidadStorage();
        public Especialidad GuardarEspecialidad(Especialidad especialidad);
        public Especialidad ActualizarEspecialidad(Especialidad especialidad);
        public List<Especialidad> ListarEspecialidad();
    }
}
