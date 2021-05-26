using System.Data;
using Market.Models;

namespace Market.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>
    {
        public EmployeeRepository(string connectionString):
            base(connectionString)
        {          
        }

    }
}
