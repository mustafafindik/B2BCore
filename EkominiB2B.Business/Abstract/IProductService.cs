using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
using EkominiB2B.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Business.Abstract
{
    public interface IProductService
    {
        IList<Product> GetAll();
        IList<Product> GetAll(params string[] navigations);
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        IList<TopProductViewModel> GetTopProducts(int? count);
    }
}
