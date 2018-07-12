using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User : IEntityBase
    {
        public User()
        {
            Roles = new List<UserRole>();
        }
        
        public int ID { get; set; }
        public string Login { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public bool IsLocked { get; set; }
        public DateTime LockedFrom { get; set; }
        public DateTime LockedTo { get; set; }
        public string LockedMessage { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual ICollection<UserRole> Roles { get; set; }
    }
}

