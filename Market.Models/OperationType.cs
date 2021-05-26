using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class OperationType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsAllowed { get; set; }
        public byte Type { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
