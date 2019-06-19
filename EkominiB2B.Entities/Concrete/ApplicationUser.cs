using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;


namespace EkominiB2B.Entities.Concrete
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserImage { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
