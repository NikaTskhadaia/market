using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Permission> Permissions { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
