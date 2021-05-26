using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Permission
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
