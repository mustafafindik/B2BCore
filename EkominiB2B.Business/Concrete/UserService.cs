using EkominiB2B.Business.Abstract;
using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace EkominiB2B.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public ApplicationUser GetByName(string Name)
        {
            return userRepository.GetByName(Name);
        }

        public void UpdateUser(ApplicationUser entity, IFormFile uploadFile)
        {
            userRepository.UpdateWithManage(entity, uploadFile);
        }
    }
}
