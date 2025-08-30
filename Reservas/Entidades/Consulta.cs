namespace Reservas.Entidades
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Notas { get; set; }
        public Reserva Reserva { set; get; }
    }
}
