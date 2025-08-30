using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas.Entidades;
using Reservas.Servicios;
namespace Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController(IConsultaService consultaService , IReservaService reservaService) : ControllerBase
    {
        private readonly IConsultaService _consultaService=consultaService;
        private readonly IReservaService _reservaService=reservaService;
        [HttpPost("[action]")]
        public Consulta ConvertirEnConsulta(Reserva reserva, string resumen)
        {
           return _consultaService.ConvertirEnConsulta(reserva, resumen);
        }
    }
}
