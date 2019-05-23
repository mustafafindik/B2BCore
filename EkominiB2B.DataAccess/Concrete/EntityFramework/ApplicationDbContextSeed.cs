using EkominiB2B.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkominiB2B.DataAccess.Concrete.EntityFramework
{
    public static class ApplicationDbContextSeed
    {
        public static void Seed(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                var category = new[] {
                    new Category() { CategoryName = "Category 1" },
                    new Category() { CategoryName = "Category 2" }
                };
                context.Categories.AddRange(category);
                context.SaveChanges();
            }



            if (!context.Products.Any())
            {
                var products = new[]
            {
                    new Product(){ ProductName="Product 1", CategoryId = 1 },
                    new Product(){ ProductName="Product 2", CategoryId = 1 },
                    new Product(){ ProductName="Product 3", CategoryId = 1},
                    new Product(){ ProductName="Product 4", CategoryId = 2},
                    new Product(){ ProductName="Product 5", CategoryId = 2},
                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }

        }
        //public static async Task CreateRootAdmin(IServiceProvider serviceProvider, IConfiguration configuration, IApplicationBuilder app)
        //{
        //    var context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

        //    var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        //    var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

        //    var username = configuration["Data:RootUser:username"];
        //    var email = configuration["Data:RootUser:email"];
        //    var password = configuration["Data:RootUser:password"];
        //    var role = configuration["Data:RootUser:role"];

        //    if (!context.RoleGroups.Any())
        //    {
        //        var RolesGroup = new[]
        //    {
        //            new RoleGroup(){RoleName="Admin" },
        //            new RoleGroup(){RoleName="User" },

        //        };
        //        context.RoleGroups.AddRange(RolesGroup);
        //        context.SaveChanges();
        //    }

        //    if (await userManager.FindByNameAsync(username) == null)
        //    {
        //        if (await roleManager.FindByNameAsync(role) == null)
        //        {
        //            ApplicationRole adminrole = new ApplicationRole()
        //            {
        //                Name = role
        //            };
        //            await roleManager.CreateAsync(adminrole);
        //        }

        //        ApplicationUser user = new ApplicationUser()
        //        {
        //            UserName = username,
        //            Email = email,
        //            Name = "Mustafa",
        //            Surname = "Fındık",
        //            RoleGroupId = 1


        //        };

        //        IdentityResult result = await userManager.CreateAsync(user, password);

        //        if (result.Succeeded)
        //        {
        //            var x = await userManager.AddToRoleAsync(user, role);
        //            if (x.Succeeded)
        //            {
        //                RoleGroupRole roleGroup = new RoleGroupRole();
        //                roleGroup.RoleGroupId = 1;
        //                roleGroup.ApplicationRoleId = context.Roles.Where(d => d.Name == role).Select(d => d.Id).FirstOrDefault();
        //                context.Add(roleGroup);
        //                context.SaveChanges();
        //            }

        //        }

        //    }

        //}

    }
}
