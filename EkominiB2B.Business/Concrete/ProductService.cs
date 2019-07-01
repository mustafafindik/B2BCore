using EkominiB2B.Business.Abstract;
using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
using EkominiB2B.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private IOrderService orderService;
        public ProductService(IProductRepository productRepository, IOrderService orderService)
        {
            this.productRepository = productRepository;
            this.orderService = orderService;

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

        public IList<TopProductViewModel> GetTopProducts(int? count)
        {
            var orders = orderService.GetAllOrderLines().GroupBy(x => x.ProductId).Select(x => new {
                SaleCount = x.Sum(i => i.Quantity),
                SalePer = x.Count(),
                ProductId = x.Key,
            });

            var xz = (from order in orders
                      join product in productRepository.GetAll()
                      on order.ProductId equals product.Id
                      select new TopProductViewModel
                      {
                          ProductId = product.Id,
                          ProductName = product.ProductName,
                          CurrentPrice = product.Price - (product.Price * product.DiscountRatio),
                          Discount = product.DiscountRatio,
                          ProdudctImage = product.Image,
                          SaleCount = order.SaleCount,
                          SalePer = order.SalePer,

                      }).OrderByDescending(x => x.SaleCount).ToList();

            if (count != 0 && count != null)
            {
                return xz.Take(count??6).ToList();
            }
            else
            {
                return xz;
            }
        }

        public void Update(Product product)
        {
            productRepository.Update(product);
        }
    }
}
