using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ruta: GymManagementSystem/Models/Reservation.cs
namespace GymManagementSystem.Models
{
    public class Reservation
    {
        public int ClassId { get; set; }
        public int ClientId { get; set; }
        public DateTime ReservationDate { get; set; }

        public Reservation(int classId, int clientId, DateTime reservationDate)
        {
            ClassId = classId;
            ClientId = clientId;
            ReservationDate = reservationDate;
        }
    }
}
