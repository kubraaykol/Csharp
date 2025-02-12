using NTierArchitecture.UI.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.UI.DataAccess.Abstractions
{
    public interface IRepository<T> where T: Entity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid Id);
        IEnumerable<T> GetAll1();
        T GetByID(Guid Id);
    }
}
