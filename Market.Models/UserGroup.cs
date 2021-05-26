using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class UserGroup
    {
        public Group Group { get; set; }
        public User User { get; set; }
        public bool IsActive { get; set; }

    }
}
