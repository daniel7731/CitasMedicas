using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public interface INotificacionService
    {
        public void Notificar(Reserva reserva);

    }
}
