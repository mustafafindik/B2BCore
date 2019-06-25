using EkominiB2B.Business.Abstract;
using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }

        public void Add(Product product)
        {
            productRepository.Add(product);

        }

        public void Delete(int id)
        {
            var entity = productRepository.Get(id);
            if (entity != null)
            {
                productRepository.Delete(entity);
            }
        }

        public Product Get(int id)
        {
            return productRepository.Get(id, "Category");
        }

        public IList<Product> GetAll()
        {
            return productRepository.GetAll().ToList();
        }

        public IList<Product> GetAll(params string[] navigations)
        {
            return productRepository.GetAll(navigations).ToList();
        }

        public void Update(Product product)
        {
            productRepository.Update(product);
        }
    }
}
