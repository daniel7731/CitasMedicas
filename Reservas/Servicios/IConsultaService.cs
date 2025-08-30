using Reservas.Entidades;
using Reservas.Repositorio;

namespace Reservas.Servicios
{
    public interface IConsultaService
    {
        protected IConsultaStorage GetConsultaStorage();
        public Consulta ConvertirEnConsulta(Reserva reserva, string resumen);
        public Consulta Guardar(Consulta consulta);
        public Consulta Encontrar(Consulta consulta);
    }
}
