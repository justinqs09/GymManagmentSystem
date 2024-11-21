using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ruta: GymManagementSystem/Models/Equipment.cs
namespace GymManagementSystem.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int LifetimeMonths { get; set; }

        public bool IsNearEndOfLife()
        {
            return (PurchaseDate.AddMonths(LifetimeMonths) - DateTime.Now).TotalDays <= 90;
        }
    }
}
