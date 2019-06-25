﻿using EkominiB2B.Business.Abstract;
using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace EkominiB2B.Business.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IOrderLineRepository orderLineRepository;
        private readonly IAddressService addressService;
      

        public OrderService(IOrderRepository orderRepository, IAddressService addressService, IOrderLineRepository orderLineRepository)
        {
            this.orderRepository = orderRepository;
            this.orderLineRepository = orderLineRepository;
            this.addressService = addressService;


        }


        public void Add(Order order)
        {
            orderRepository.Add(order);
            List<OrderLine> orderLines = new List<OrderLine>();
            orderLines = order.orderLine;
            foreach (var item in orderLines)
            {
                item.Id = 0;
                item.Order = null;
                orderLineRepository.Add(item);
              
            }

        }

        public void Delete(int id)
        {
            var entity = orderRepository.Get(id);
            if (entity != null)
            {
                orderRepository.Delete(entity);
           
                var lines = orderLineRepository.Find(d => d.OrderId == id).ToList();
                foreach (var item in lines)
                {
                    orderLineRepository.Delete(item);
               
                }
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

        public void Update(Order order, List<OrderLine> orderLines)
        {
            orderRepository.Update(order);

        }

        public Order CartToOrder(Cart cart,double ship,ApplicationUser user)
        {
           
            Order order = new Order();                   
            order.OrderDate = DateTime.Now;
            order.Total = cart.Total??0 + ship;
            order.Shipping = ship;
            order.AddressId = addressService.GetDefault(user.Id).Id;
            order.ApplicationUserId = user.Id;
            order.CreatedAt = DateTime.Now;
            order.CreatedBy = user.Email;
            order.UpdatedAt = DateTime.Now;
            order.UpdatedBy = user.Email;

            foreach (var item in cart.CartLines)
            {
                OrderLine orderLine = new OrderLine();
                orderLine.CreatedAt = DateTime.Now;
                orderLine.CreatedBy = user.Email;
                orderLine.UpdatedAt = DateTime.Now;
                orderLine.UpdatedBy = user.Email;
                orderLine.OrderId = order.Id;
                orderLine.ProductId = item.Product.Id;
                orderLine.Quantity = item.Quantity;
                order.orderLine.Add(orderLine);
            }
          
            return order;
           
        }
    }
}
