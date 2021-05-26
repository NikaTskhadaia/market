using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    public class ProductPrice
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public decimal Price { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
