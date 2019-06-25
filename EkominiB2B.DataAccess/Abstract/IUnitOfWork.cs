using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IAddressRepository Addresses { get; }
        IOrderRepository Orders { get; }
        IOrderLineRepository OrderLines { get; }
        int SaveChanges();
    }
}
