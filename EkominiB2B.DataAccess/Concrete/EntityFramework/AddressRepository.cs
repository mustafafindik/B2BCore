using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Concrete.EntityFramework
{
    class AddressRepositor :BaseRepository<Address>, IAddressRepository
    {
        public AddressRepositor(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationDbContext Context
        {
            get { return Context as ApplicationDbContext; }
        }
    }
}
