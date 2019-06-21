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
        private readonly IBaseRepository<Address> addressRepository;
        private readonly IUnitOfWork unitOfWork;
        public AddressService(IBaseRepository<Address> addressRepository, IUnitOfWork unitOfWork)
        {
            this.addressRepository = addressRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(Address address)
        {
            addressRepository.Add(address);
            unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = addressRepository.Get(id);
            if (entity != null)
            {
                addressRepository.Delete(entity);
                unitOfWork.SaveChanges();
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

        public void Update(Address address)
        {
            addressRepository.Update(address);
            unitOfWork.SaveChanges();
        }
    }
}
