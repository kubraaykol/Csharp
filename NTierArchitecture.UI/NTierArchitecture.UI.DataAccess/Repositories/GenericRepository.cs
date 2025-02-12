using Microsoft.EntityFrameworkCore;
using NTierArchitecture.UI.DataAccess.Abstractions;
using NTierArchitecture.UI.DataAccess.Context;
using NTierArchitecture.UI.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.UI.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDBContext context) 
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            _dbSet.Remove(GetByID(Id));
            _dbContext.SaveChanges();

        }

        public IEnumerable<T> GetAll1()
        {
            return _dbSet.ToList();
        }

        public T GetByID(Guid Id)
        {
            //return _dbSet.FirstOrDefault(x => x.Id == Id); ?? throw new ///ExceptionException("Bulunamadı");
           var data= _dbSet.FirstOrDefault(x => x.Id == Id);
            if(data==null)
            {
              throw new Exception("Bulunamadı");
            }
            return data;

            //! bir ifadenin kesinlikle null gelmeyceğini bildirmek için kullanılır.
            //return (_dbSet.FirstOrDefault(x => x.Id == Id))!;
        }

        public void Update(T entity)
        {
            _dbContext.SaveChanges();
        }
    }
}
