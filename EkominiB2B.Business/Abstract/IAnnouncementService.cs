using EkominiB2B.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Business.Abstract
{
    public interface IAnnouncementService
    {
        IList<Announcement> GetAll();
        IList<Announcement> GetAll(params string[] navigations);
        Announcement Get(int id);
        void Add(Announcement announcement);
        void Update(Announcement announcement);
        void Delete(int id);      
    }
}
