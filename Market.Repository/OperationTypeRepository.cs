using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class OperationTypeRepository : RepositoryBase<OperationType>
    {
        public OperationTypeRepository(string connectionString) :
            base(connectionString)
        {
        }
    }
}
