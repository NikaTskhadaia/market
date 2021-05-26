using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<ProductPrice> Prices { get; set; }
    }
}
