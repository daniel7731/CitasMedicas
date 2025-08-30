namespace Reservas.Servicios
{
    public class DefaultLogServices : ILogService
    {
        public void Log(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
