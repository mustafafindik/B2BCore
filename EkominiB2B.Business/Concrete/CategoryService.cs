using EkominiB2B.Business.Abstract;
using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Business.Concrete
{
    public class CategoryService : ICategoryService
    {

        private readonly IBaseRepository<Category> categoryRepository;
        private readonly IUnitOfWork unitOfWork;
        public CategoryService(IBaseRepository<Category> categoryRepository, IUnitOfWork unitOfWork)
        {
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }


        public void Delete(int id)
        {
            var entity = categoryRepository.Get(id);
            if (entity != null)
            {
                categoryRepository.Delete(entity);
                unitOfWork.SaveChanges();
            }
        }

        public Category Get(int id)
        {
            return categoryRepository.Get(id);
        }

        public IList<Category> GetAll()
        {       
            return categoryRepository.GetAll().ToList();
        }

        public void Add(Category category)
        {
            categoryRepository.Add(category);
            unitOfWork.SaveChanges();
        }

        public void Update(Category category)
        {
            categoryRepository.Update(category);
            unitOfWork.SaveChanges();
        }

        
    }
}
