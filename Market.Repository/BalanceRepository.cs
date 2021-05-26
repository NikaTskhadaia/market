using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class BalanceRepository : RepositoryBase<Balance>
    {
        public BalanceRepository(string connectionString) :
            base(connectionString)
        {
        }
    }
}
