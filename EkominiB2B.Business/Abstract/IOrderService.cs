using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Business.Abstract
{
    public interface IOrderService
    {
        IList<Order> GetAll();
        IList<Order> GetAll(params string[] navigations);
        IList<OrderLine> GetAllOrderLines(string Id);
        Order Get(int id);
        List<Order> GetByUserId(string UserId);
        Order CartToOrder(Cart cart, double ship, ApplicationUser user);
        void Add(Order order);
        void Update(Order order, List<OrderLine> orderLine);
        void Delete(int id);
    }
}
