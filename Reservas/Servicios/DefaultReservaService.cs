using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public class DefaultReservaService : IReservaService
    {
        private readonly IReservaStorage _storage;
        public DefaultReservaService()
        {
            _storage = new MemoryReservaStorage();
        }
        public DefaultReservaService(IReservaStorage storage) {
            _storage = storage;
        }
        public Reserva AprobarReserva(Reserva reserva, bool aprobar)
        {
            //throw new NotImplementedException();
            Console.WriteLine("AprobarReserva");
            return null;
        }

        public Reserva CancelarReserva(Reserva reserva)
        {
            Console.WriteLine("AprobarReserva");
            return null;
        }

        public IReservaStorage GetReservaStorage()
        {
            throw new NotImplementedException();
        }

        public List<Reserva> ListarAgenda(Doctor doctor, DateTime FechaInicio, DateTime FechaFin)
        {
            throw new NotImplementedException();
        }

        public Reserva RegistrarReserva(Reserva reserva)
        {
            Console.WriteLine("AprobarReserva");
            reserva = _storage.Guardar(reserva);

            return reserva;
        }

        public Reserva ReprogramarReserva(Reserva reserva , DateTime newFecha)
        {
            Console.WriteLine("AprobarReserva");
            return null;
        }
    }
}
