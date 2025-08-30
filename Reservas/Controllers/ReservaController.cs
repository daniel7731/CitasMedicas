using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas.Entidades;
using Reservas.Servicios;
namespace Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController(IReservaService reservaService , ILogService logService , INotificacionService notificacionService) : ControllerBase
    {
        private readonly IReservaService _reservaService = reservaService;
        private readonly ILogService _logService = logService;
        private readonly INotificacionService _notificacionService = notificacionService;

        [HttpPost("[action]")]
        public Reserva RegistrarReserva(Reserva newReserva)
        {
           
            Reserva reserva = _reservaService.RegistrarReserva(newReserva);
            if (reserva != null)
            {
                _logService.Log("reserva realizada con exito");
                _notificacionService.Notificar(reserva);
            }
            else
            {
                _logService.Log("no se logro realizar la reserva");
            }
            return reserva;
        }
        [HttpPost("[action]")]
        public Reserva CancelarReserva(Reserva reserva)
        {
            _reservaService.CancelarReserva(reserva);
            if (reserva != null)
            {
                _logService.Log("cancelada con exito");
                _notificacionService.Notificar(reserva);
            }
            else
            {
                _logService.Log("Error ");
            }
            return reserva;
        }
        [HttpPost("[action]")]
        public Reserva Reprogramar(Reserva reserva , DateTime newFecha)
        {
            _reservaService.ReprogramarReserva(reserva , newFecha);
            if (reserva != null)
            {
                _logService.Log("cancelada con exito");
            }
            else
            {
                _logService.Log("Error ");
            }
            return reserva;
        }
        [HttpPost("[action]")]
        public List<Reserva> ListarAgenda(Doctor doctor , DateTime FechaInicio, DateTime FechaFin) {
           return  _reservaService.ListarAgenda(doctor, FechaInicio, FechaFin);
        }
        [HttpPost("[action]")]
        public Reserva AprobarReserva(Reserva reserva, bool aprobar) {
            return _reservaService.AprobarReserva(reserva, aprobar);
        }
    }
}
