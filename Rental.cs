using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rental : IEntityBase
    {
        public Rental()
        {
            Apartments = new List<Apartment>();
        }

        public int ID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public virtual RentalStatus Status { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
