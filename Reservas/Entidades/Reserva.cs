
namespace Reservas.Entidades
{
    public class Reserva 
    {
        public int Id { get; set; }  
        public DateTime FechaHora { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Especialidad Especialidad { get; set; }
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }
    }
}
