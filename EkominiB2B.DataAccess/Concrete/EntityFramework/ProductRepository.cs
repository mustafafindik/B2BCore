using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Concrete.EntityFramework
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationDbContext Context
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
