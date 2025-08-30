using Reservas.Entidades;
using System.Collections;

namespace Reservas.Repositorio
{
    public class MemoryReservaStorage : IReservaStorage
    {
        private Dictionary<Int32, Reserva> collection;
        private int IdCount;
        public MemoryReservaStorage()
        {
            collection = [];
            
        }
        public Reserva Actualizar(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public Reserva EliminarReserva(Reserva reserva)
        {
            if (reserva != null)
            {
                collection.Remove(reserva.Id);

            }
            return reserva;
        }

        public Reserva EncontrarReserva(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public Reserva Guardar(Reserva reserva)
        {
            if ( reserva != null)
            {
                if ( reserva.Id == 0)
                {
                    IdCount++;
                    reserva.Id = IdCount;
                    collection.Add(reserva.Id, reserva);
                    
                }
                else
                {
                   if (collection.ContainsKey(reserva.Id))
                   {
                        collection[reserva.Id] = reserva;
                      
                   }

                }
                

            }
            return reserva;
        }

        public List<Reserva> ListarReserva(Doctor doctor ,DateTime FechaInicio, DateTime FechaFin)
        {
            throw new NotImplementedException();
        }
    }
}
