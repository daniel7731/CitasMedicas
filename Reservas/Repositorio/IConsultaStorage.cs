using Reservas.Entidades;
namespace Reservas.Repositorio
{
    public interface IConsultaStorage
    {
        public Consulta Guardar(Consulta consulta);
        public Consulta Encontrar(Consulta consulta);
        public Consulta EncontrarPorReserva(Reserva reserva);
    }
}
