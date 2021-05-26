using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class ProductPriceRepository : RepositoryBase<ProductPrice>
    {
        public ProductPriceRepository(string connectionString) :
            base(connectionString)
        {
        }
    }
}
