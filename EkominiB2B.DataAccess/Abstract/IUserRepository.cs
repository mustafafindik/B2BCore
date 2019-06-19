using EkominiB2B.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.DataAccess.Abstract
{
    public interface IUserRepository 
    {
        void UpdateWithManage(ApplicationUser entity, IFormFile uploadFile);
        ApplicationUser GetByName(string Name);
    }
}
