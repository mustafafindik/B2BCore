using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Entities.Concrete
{
    public class Announcement:BaseEntity   
    {
        public string Title { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public string CoverImage { get; set; }
        public bool IsActive { get; set; }
    }
}
