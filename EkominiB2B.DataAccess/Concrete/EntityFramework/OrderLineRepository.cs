﻿using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Concrete.EntityFramework
{
    class OrderLineRepository : BaseRepository<OrderLine>, IOrderLineRepository
    {
        public OrderLineRepository(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationDbContext Context
        {
            get { return Context as ApplicationDbContext; }
        }

        public void DeleteAll(List<OrderLine> entities)
        {
            _context.RemoveRange(entities);
            _context.SaveChanges();
        }
    }
}
