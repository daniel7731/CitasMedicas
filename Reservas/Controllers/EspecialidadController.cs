using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas.Entidades;
using Reservas.Servicios;

namespace Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadController(IEspecialidadService especialidadService,ILogService logService) : ControllerBase
    {
        private readonly ILogService logService =logService;
        private readonly IEspecialidadService service = especialidadService;
        [HttpPost("[action]")]
        public Especialidad RegistrarEpecialidad(Especialidad especialidad)
        {
            return service.GuardarEspecialidad(especialidad);
        }
        [HttpGet("[action]")]
        public List<Especialidad> ListarEspecialidad()
        {
            return service.ListarEspecialidad();
        }

    }
}
