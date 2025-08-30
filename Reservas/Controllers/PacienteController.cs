using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas.Entidades;
using Reservas.Repositorio;
using Reservas.Servicios;
using System.Net.Sockets;

namespace Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController (IPacienteService pacienteService , ILogService logService, INotificacionService notificacionService) : ControllerBase
    {
        private readonly IPacienteService _pacienteService = pacienteService;
        private readonly ILogService _logService = logService;
        private readonly INotificacionService _notificacionService = notificacionService;
        [HttpPost("[action]")]
        public Paciente RegistrarPaciente(Paciente paciente)
        {
            return _pacienteService.RegistarPaciente(paciente);
            
        }
        [HttpPost("[action]")]
        public Paciente ActualizarPaciente(Paciente paciente)
        {
            return _pacienteService.ActualizarPaciente(paciente);

        }
    }
}
