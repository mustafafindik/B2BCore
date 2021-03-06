﻿using EkominiB2B.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Concrete.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException("Veri Tabanı Bağlantısı Bulunamadı");
        }

        private IProductRepository _products;
        private ICategoryRepository _categories;
        private IAddressRepository _addresses;

        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new ProductRepository(_context));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new CategoryRepository(_context));
            }
        }

        public IAddressRepository Addresses
        {
            get
            {
                return _addresses ?? (_addresses = new AddressRepository(_context));
            }
        }

        public IOrderRepository Orders => throw new NotImplementedException();

        public IOrderLineRepository OrderLines => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
        }


        public int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
