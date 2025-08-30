using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public class DefaultDoctorService : IDoctorService
    {
        private readonly IDoctorStorage _storage;
        public DefaultDoctorService()
        {
            _storage = new MemoryDoctorStorage();
        }
        public DefaultDoctorService(IDoctorStorage storage)
        {
            _storage = storage;
        }
        public Doctor ActualizarDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public IDoctorStorage GetDoctorStorage()
        {
            throw new NotImplementedException();
        }

        public Doctor GuardarDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> ListarDoctor()
        {
            throw new NotImplementedException();
        }
    }
}
