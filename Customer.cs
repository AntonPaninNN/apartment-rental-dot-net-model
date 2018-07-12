using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer : IEntityBase
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string PassportData { get; set; }
        public string Notes { get; set; }
    }
}
