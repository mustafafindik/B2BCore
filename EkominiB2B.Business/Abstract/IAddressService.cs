using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Business.Abstract
{
    public interface IAddressService
    {
        IList<Address> GetAll();
        IList<Address> GetAll(params string[] navigations);
        Address GetById(int id);
        IList<Address> GetByUserId(string UserId);
        void Add(Address address);
        void Update(Address address);
        void Delete(int id);
    }
}
