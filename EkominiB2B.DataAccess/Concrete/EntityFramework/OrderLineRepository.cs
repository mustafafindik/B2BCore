using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.DataAccess.Concrete.EntityFramework
{
    public class OrderLineRepository : BaseRepository<OrderLine>, IOrderLineRepository
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

        public List<OrderLine> GetAllById(string Id)
        {
            return _context.OrderLines.Include(d => d.Product).Include(d => d.Order).ThenInclude(d => d.OrderStatus).Include(d=>d.Order).ThenInclude(d=>d.Address).Where(d => d.Order.ApplicationUserId == Id).ToList();
        }
    }
}
