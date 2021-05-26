using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime PasswordExpDate { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
