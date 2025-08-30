using Reservas.Entidades;

namespace Reservas.Servicios
{
    public class EmailNotificacionService : INotificacionService
    {
        public void Notificar(Reserva reserva)
        {
            Console.WriteLine(reserva.Id);
        }
    }
}
