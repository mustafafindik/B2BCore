
using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Business.Abstract
{
    public interface ICategoryService
    {
        IList<Category> GetAll();
        Category Get(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}
