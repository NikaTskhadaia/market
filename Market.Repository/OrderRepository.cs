using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(string connectionString) :
            base(connectionString)
        {
        }
    }
}
