using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public interface IReservaService
    {
       
        protected IReservaStorage GetReservaStorage();
        public Reserva RegistrarReserva(Reserva reserva);

        public Reserva CancelarReserva(Reserva reserva);
        public Reserva ReprogramarReserva(Reserva reserva , DateTime newFecha);
        /**
         * Aprueba o recha la reserva
         * **/
        public Reserva AprobarReserva(Reserva reserva , bool aprobar);
        public List<Reserva> ListarAgenda(Doctor doctor, DateTime FechaInicio, DateTime FechaFin);
    }
}
