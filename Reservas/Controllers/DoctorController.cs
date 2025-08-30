using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas.Entidades;
using Reservas.Servicios;
namespace Reservas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController(IDoctorService doctorService , ILogService logService) : ControllerBase
    {
        private readonly IDoctorService _doctorService=doctorService;
        private readonly ILogService _logService=logService;
        [HttpPost("[action]")]
        public Doctor GuardarDoctor(Doctor doctor)
        {
            return _doctorService.GuardarDoctor(doctor);

        }
        [HttpGet("[action]")]
        public List<Doctor> ListarDoctor()
        {
            return _doctorService.ListarDoctor();                
        }
    }
}
