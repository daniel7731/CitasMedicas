using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public interface IDoctorService
    {
        protected IDoctorStorage GetDoctorStorage();
        public Doctor GuardarDoctor(Doctor doctor);
        public Doctor ActualizarDoctor(Doctor doctor);
        public List<Doctor> ListarDoctor();
    }
}
