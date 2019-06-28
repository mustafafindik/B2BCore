using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.DataAccess.Concrete.EntityFramework
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationDbContext Context
        {
            get { return Context as ApplicationDbContext; }
        }

        public List<Order> GetAllforUser(string id, params string[] navigations)
        {

            var query = _context.Set<Order>().AsNoTracking().AsQueryable();
            foreach (var nav in navigations)
            {
                query = query.Include(nav);
            }

            return query.Where(e => e.ApplicationUserId == id).ToList();
        }
    }
}
