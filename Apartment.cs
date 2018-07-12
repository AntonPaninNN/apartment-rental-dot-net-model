using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Apartment : IEntityBase
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public int RoomNumber { get; set; }
        public short Floor { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public List<string> ImageUrls { get; set; }
    }
}
