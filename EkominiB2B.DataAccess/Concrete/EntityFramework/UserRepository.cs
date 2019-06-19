using EkominiB2B.DataAccess.Abstract;
using EkominiB2B.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EkominiB2B.DataAccess.Concrete.EntityFramework
{
    public class UserRepository :  IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager) 
        {
            _context = context;
            _userManager = userManager;
        }

        public ApplicationUser GetByName(string Name)
        {
            return _context.Users.FirstOrDefault(d => d.UserName == Name);
        }

        public void UpdateWithManage(ApplicationUser entity, IFormFile uploadFile)
        {
            var userModified = _context.Users.FirstOrDefault(xx => xx.Id == entity.Id);
            if (uploadFile != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\UserImages", uploadFile.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    uploadFile.CopyTo(stream);

                    userModified.UserImage = uploadFile.FileName;
                }
            }

            _userManager.SetUserNameAsync(userModified, entity.UserName).ConfigureAwait(false); ;
            _userManager.SetEmailAsync(userModified, entity.Email).ConfigureAwait(false); ;
            _userManager.SetPhoneNumberAsync(userModified, entity.PhoneNumber).ConfigureAwait(false);


            userModified.Name = entity.Name;
            userModified.Surname = entity.Surname;
            userModified.IsActive = entity.IsActive;
            userModified.EmailConfirmed = entity.EmailConfirmed;
            userModified.PhoneNumberConfirmed = entity.PhoneNumberConfirmed;

            _context.Update(userModified);
            _context.SaveChanges();
        }

        
    }
}
