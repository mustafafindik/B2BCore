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
        Order Get(int id);
        void Add(Order order,OrderLine orderLine);
        void Update(Order order, OrderLine orderLine);
        void Delete(int id);
    }
}
