using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public class DefaultConsultaService : IConsultaService
    {
        private readonly IConsultaStorage _consultaStorage;
        public DefaultConsultaService()
        {
            _consultaStorage= new MemoryConsultaStorage();

        }
        public DefaultConsultaService(IConsultaStorage consultaStorage)
        {
            _consultaStorage = consultaStorage;
        }
        public Consulta ConvertirEnConsulta(Reserva reserva, string resumen)
        {
            Consulta consulta = new Consulta();
            consulta.Reserva= reserva;
            consulta.Notas = resumen;
            return _consultaStorage.Guardar(consulta);
        }

        public Consulta Encontrar(Consulta consulta)
        {
            return _consultaStorage.Encontrar(consulta);
        }

        public IConsultaStorage GetConsultaStorage()
        {
            throw new NotImplementedException();
        }

        public Consulta Guardar(Consulta consulta)
        {
            return _consultaStorage.Guardar(consulta);
        }

       
    }
}
