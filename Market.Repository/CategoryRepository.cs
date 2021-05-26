using Market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Repository
{
    public class CategoryRepository : RepositoryBase<Category>
    {        
        public CategoryRepository(string connectionString) :
            base(connectionString)
        {
        }
    }
}
