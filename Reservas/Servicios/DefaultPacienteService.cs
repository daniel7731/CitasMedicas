using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public class DefaultPacienteService : IPacienteService
    {
        private readonly IPacienteStorage _storage;
        
        public DefaultPacienteService()
        {
            _storage = new MemoryPacienteStorage();
        }
        public DefaultPacienteService(IPacienteStorage storage)
        {
          _storage = storage;
        }
        public Paciente ActualizarPaciente(Paciente paciente)
        {
           return _storage.Actualizar(paciente);
        }

        public IPacienteStorage GetPacienteStorage()
        {
            throw new NotImplementedException();
        }

        public Paciente RegistarPaciente(Paciente paciente)
        {
            return _storage.Guardar(paciente);
        }
    }
}
