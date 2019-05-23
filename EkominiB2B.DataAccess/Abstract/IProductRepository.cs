
using EkominiB2B.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Abstract
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        // istersek sadece bu bölümde kullanacagımız metoları bu kısma yazabiliriz
    }
}
