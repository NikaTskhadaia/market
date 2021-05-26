using System;
using System.Collections.Generic;

namespace Market.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentCategoryID { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Product> Products { get ; set; }
    }
}