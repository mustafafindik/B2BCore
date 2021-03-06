﻿using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Abstract
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        List<Order> GetAllforUser(string id, params string[] navigations);
    }
}
