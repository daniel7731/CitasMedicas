using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public interface IPacienteService
    {
        protected IPacienteStorage GetPacienteStorage();
        public Paciente RegistarPaciente(Paciente paciente);
        public Paciente ActualizarPaciente(Paciente paciente);
    }
}
