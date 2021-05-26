using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int OpertionID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Order> OrderDetails { get; set; }
    }
}
