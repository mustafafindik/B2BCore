using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        int SaveChanges();
    }
}
