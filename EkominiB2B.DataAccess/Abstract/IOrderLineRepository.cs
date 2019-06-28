using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Abstract
{
    public interface IOrderLineRepository : IBaseRepository<OrderLine>
    {
        List<OrderLine> GetAllById(string Id);
        void DeleteAll(List<OrderLine> entities);
    }
}
