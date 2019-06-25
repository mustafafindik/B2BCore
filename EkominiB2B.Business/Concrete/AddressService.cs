using EkominiB2B.Business.Abstract;
using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Business.Concrete
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository addressRepository;
        public AddressService(IAddressRepository addressRepository)
        {
            this.addressRepository = addressRepository;
          
        }

        public void Add(Address address)
        {
            addressRepository.Add(address);
           
        }

        public void Delete(int id)
        {
            var entity = addressRepository.Get(id);
            if (entity != null)
            {
                addressRepository.Delete(entity);           
            }
        }

        public IList<Address> GetAll()
        {
            return addressRepository.GetAll().ToList();
        }

        public IList<Address> GetAll(params string[] navigations)
        {
            return addressRepository.GetAll(navigations).ToList();
        }

        public Address GetById(int id)
        {
            return addressRepository.Get(id);
        }

        public IList<Address> GetByUserId(string UserId)
        {
            return addressRepository.Find(d => d.ApplicationUserId == UserId).ToList(); ;
        }

        public Address GetDefault(string UserId)
        {
            return addressRepository.Find(d => d.ApplicationUserId == UserId).Where(d => d.IsDefault == true).FirstOrDefault();
        }

        public void MakeDefault(int id)
        {
            var old = addressRepository.GetAll().Where(d => d.IsDefault == true).FirstOrDefault();          
            if (old != null)
            {
                old.IsDefault = false;
                addressRepository.Update(old);
            }

            var new_ = addressRepository.Get(id);
            new_.IsDefault = true;
            addressRepository.Update(new_);
        }

   

        public void Update(Address address)
        {
            addressRepository.Update(address);
        }
    }
}
