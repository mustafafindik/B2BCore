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
        private readonly IBaseRepository<Product> productRepository;
        private readonly IUnitOfWork unitOfWork;
        public ProductService(IBaseRepository<Product> productRepository, IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(Product product)
        {
            productRepository.Add(product);
            unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = productRepository.Get(id);
            if (entity != null)
            {
                productRepository.Delete(entity);
                unitOfWork.SaveChanges();
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

        public void Update(Product product)
        {
            productRepository.Update(product);
            unitOfWork.SaveChanges();
        }
    }
}
