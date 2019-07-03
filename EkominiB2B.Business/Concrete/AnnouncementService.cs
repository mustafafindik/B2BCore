using EkominiB2B.Business.Abstract;
using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using EkominiB2B.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EkominiB2B.Business.Concrete
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IAnnouncementRepository announcementRepository;
 
        public AnnouncementService(IAnnouncementRepository announcementRepository)
        {
            this.announcementRepository = announcementRepository;
        }

        public void Add(Announcement announcement)
        {
            announcementRepository.Add(announcement);
        }

        public void Delete(int id)
        {
            var entity = announcementRepository.Get(id);
            if (entity != null)
            {
                announcementRepository.Delete(entity);
            }
        }

        public Announcement Get(int id)
        {
            return announcementRepository.Get(id , "ApplicationUser");
        }

        public IList<Announcement> GetAll()
        {
            return announcementRepository.GetAll().ToList();
        }

        public IList<Announcement> GetAll(params string[] navigations)
        {
            return announcementRepository.GetAll(navigations).ToList();
        }

        public void Update(Announcement announcement)
        {
            announcementRepository.Update(announcement);
        }
    }
}
