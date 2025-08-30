using Reservas.Entidades;

namespace Reservas.Repositorio
{
    public interface IPacienteStorage
    {
        public Paciente Guardar(Paciente paciente);
        public Paciente Actualizar(Paciente paciente);
        public Paciente EncontrarPaciente(Paciente paciente);
        public Paciente EliminarPaciente(Paciente paciente);
        public List<Paciente> ListarPaciente();
    }
}
