using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.UI.Business.Abstractions
{
    public interface IManager<T> where T : class 
    {
        
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid Id);
        IEnumerable<T> GetAll1();
        T GetByID(Guid Id);
    }
}
