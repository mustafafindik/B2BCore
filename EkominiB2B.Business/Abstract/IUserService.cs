using EkominiB2B.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Business.Abstract
{
    public interface IUserService
    {
        void UpdateUser(ApplicationUser entity, IFormFile uploadFile);
        ApplicationUser GetByName(string Name);
    }
}
