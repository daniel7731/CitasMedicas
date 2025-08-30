using Reservas.Entidades;

namespace Reservas.Repositorio
{
    public interface IReservaStorage
    {
        public Reserva Guardar(Reserva reserva);
        public Reserva Actualizar(Reserva reserva);
        public Reserva EncontrarReserva(Reserva reserva);
        public Reserva EliminarReserva(Reserva reserva);
        public List<Reserva> ListarReserva(Doctor doctor , DateTime FechaInicio , DateTime FechaFin);
    }
}
