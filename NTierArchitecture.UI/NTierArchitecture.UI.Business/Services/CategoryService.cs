using FluentValidation.Results;
using NTierArchitecture.UI.Business.Abstractions;
using NTierArchitecture.UI.Business.Validators;
using NTierArchitecture.UI.DataAccess.Repositories;
using NTierArchitecture.UI.Entities.Models;
using System.Text;

namespace NTierArchitecture.UI.Business.Services
{
    public class CategoryService : IManager<Category>
    {
        private readonly CategoryRepository _repository;
        public CategoryService(CategoryRepository catRepo)
        {
            _repository = catRepo;
        }
        public void Create(Category entity)
        {
            //Install-Package FluentValidation
            CategoryValidator cval = new();
            ValidationResult result=cval.Validate(entity);
            StringBuilder sb = new();
            result.Errors.ForEach(x => sb.AppendLine(x.ToString()));

            if (!result.IsValid)
            {
                //throw new Exception(string.Join(",",result.Errors));
                throw new Exception(sb.ToString());
            }

            _repository.Create(entity);
        }

        public void Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll1()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
