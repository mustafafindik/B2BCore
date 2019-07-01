using EkominiB2B.Business.Abstract;
using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Business.Concrete
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }


        public void Delete(int id)
        {
            var entity = categoryRepository.Get(id);
            if (entity != null)
            {
                categoryRepository.Delete(entity);
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
        }

        public void Update(Category category)
        {
            categoryRepository.Update(category);
        }

        
    }
}
