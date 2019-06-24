using EkominiB2B.Business.Abstract;
using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Business.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IBaseRepository<Order> orderRepository;
        private readonly IOrderLineRepository orderLineRepository;
        private readonly IUnitOfWork unitOfWork;
        public OrderService(IBaseRepository<Order> orderRepository, IOrderLineRepository orderLineRepository, IUnitOfWork unitOfWork)
        {
            this.orderRepository = orderRepository;
            this.orderLineRepository = orderLineRepository;
            this.unitOfWork = unitOfWork;
        }


        public void Add(Order order, OrderLine orderLine)
        {
            orderRepository.Add(order);
            orderLineRepository.Add(orderLine);
            unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = orderRepository.Get(id);
            if (entity != null)
            {
                orderRepository.Delete(entity);
                unitOfWork.SaveChanges();
                var lines = orderLineRepository.Find(d => d.OrderId == id).ToList();
                orderLineRepository.DeleteAll(lines);
            }
        }

        public Order Get(int id)
        {         
            return orderRepository.Get(id, "OrderLine");
        }

        public IList<Order> GetAll()
        {
            return orderRepository.GetAll().ToList();
        }

        public IList<Order> GetAll(params string[] navigations)
        {
            return orderRepository.GetAll(navigations).ToList();
        }

        public void Update(Order order, OrderLine orderLine)
        {
            orderRepository.Update(order);
            orderLineRepository.Update(orderLine);
            unitOfWork.SaveChanges();
        }
    }
}
