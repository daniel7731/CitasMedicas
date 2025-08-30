using Reservas.Entidades;

namespace Reservas.Repositorio
{
    public interface IEspecialidadStorage
    {
        public Especialidad Guardar(Especialidad especialidad);
        public Especialidad Actualizar(Especialidad especialidad);
        public Especialidad EncontrarEspeciliadad(Especialidad especialidad);
        public Especialidad EliminarEspeciliadad(Especialidad especialidad);
        public List<Especialidad> Listar();
    }
}
