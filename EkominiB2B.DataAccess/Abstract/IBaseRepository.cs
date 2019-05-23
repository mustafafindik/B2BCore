using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EkominiB2B.DataAccess.Abstract
{
    public interface IBaseRepository<T> where T : BaseEntity //Burada T diye bahsedilen bir class , generik biçimde üretmek için ismine T diyoruz.
    {
        // Tüm Repositorylerde kullandığımız metodları heryerde kullanmamak için böyle bir base Repository interface hazılıyoruz.
        T Get(int id);
        T Get(int id, params string[] navigations);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(params string[] navigations);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
       

    }
}
