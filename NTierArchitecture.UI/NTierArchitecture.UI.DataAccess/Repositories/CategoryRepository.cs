using NTierArchitecture.UI.DataAccess.Context;
using NTierArchitecture.UI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.UI.DataAccess.Repositories
{
    public class CategoryRepository : GenericRepository<Category>

    {
        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
