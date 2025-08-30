using Reservas.Entidades;

namespace Reservas.Repositorio
{
    public interface IDoctorStorage
    {
        public Doctor Guardar(Doctor doctor);
        public Doctor Actualizar(Doctor doctor);
        public Doctor EncontrarDoctor(Doctor doctor);
        public Doctor EliminarReserva(Doctor doctor);
        public List<Doctor> ListarDoctor(Especialidad especialidad);
    }
}
