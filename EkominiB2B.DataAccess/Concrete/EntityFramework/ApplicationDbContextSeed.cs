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
                    new Category() { CategoryName = "Atıştırmalık" },
                    new Category() { CategoryName = "Bakliyat Ve Yağ" },
                    new Category() { CategoryName = "Bisküvi" },
                    new Category() { CategoryName = "Çay" },
                    new Category() { CategoryName = "Temizlik" }

                };
                context.Categories.AddRange(category);
                context.SaveChanges();
            }



            if (!context.Products.Any())
            {
                var products = new[]
            {
                    new Product(){ ProductName="MIGROS TUZLU FISTIK 200 G", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/1.jpg" ,Description="Migros Tuzlu Fıstık sohbetlerinize lezzet katar. Tazecik tuzlu fıstığı misafirlerinize ikram edebilir, evde, parkta, istediğiniz her yerde tüketebilirsiniz. Migros kalite ve güvencesi ile üretilip paketlenmiş olan çerezi arzu ettiğiniz diğer çerezlerle karıştırarak ya da tek başına sunabilirsiniz. Yaklaşık 10 porsiyondan oluşmaktadır." },
                    new Product(){ ProductName="MIGROS KAVRULMUŞ FINDIK 200 G	", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/2.jpg" },
                    new Product(){ ProductName="MIGROS KARIŞIK KURUYEMİŞ 200 G	", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/3.jpg" ,Description=""},
                    new Product(){ ProductName="MIGROS BEYAZ LEBLEBİ 200 G	", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/4.jpg" ,Description="" },

                    new Product(){ ProductName="MİGROS PİLAVLIK İTHAL PİRİNÇ 1000 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/5.jpg" , Description="" },
                    new Product(){ ProductName="MİGROS BALDO PİRİNÇ 1000 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/6.jpg"  , Description="" },
                    new Product(){ ProductName="MİGROS DERMASON KURU FASULYE 1000 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/7.jpg"  , Description="" },
                    new Product(){ ProductName="MİGROS KIRMIZI MERCİMEK 1000 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/8.jpg"  , Description="" },
                    new Product(){ ProductName="MIGROS TOZ ŞEKER 1 KG	", CategoryId =2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/9.jpg"   , Description=""},
                    new Product(){ ProductName="MİGROS AYÇİÇEK YAĞI 1 L	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/10.jpg"  , Description="" },
                    new Product(){ ProductName="MİGROS FİYONK MAKARNA 500 GR	", CategoryId =2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/11.jpg"   , Description=""},
                    new Product(){ ProductName="MİGROS SPAGETTİ MAKARNA 500 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/12.jpg"   , Description=""},
                    new Product(){ ProductName="MİGROS BURGU MAKARNA 500GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/13.jpg"  , Description="" },
                    new Product(){ ProductName="MİGROS ARPA ŞEHRİYE 500GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/14.jpg"  , Description="" },
                    new Product(){ ProductName="MİGROS TEL ŞEHRİYE 500GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/15.jpg"   , Description=""},

                    new Product(){ ProductName="MİGROS ÇİKOLATA KAPLAMALI SANDVİÇ 30G	", CategoryId =3 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/16.jpg"  , Description="" },
                    new Product(){ ProductName="MIGROS KAKAO KREMALI SANDVİÇ BİSKÜVİ 10'LU 300 G	", CategoryId = 3 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/17.jpg"  , Description="" },

                    new Product(){ ProductName="MİGROS RİZE ÇAY 1000 G	", CategoryId =4 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/18.jpg"  , Description="" },

                    new Product(){ ProductName="MİGROS 72 Lİ ISLAK HAVLU	", CategoryId =5 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/19.jpg"  , Description="" },
                    new Product(){ ProductName="MINIES MAXI 4 NUMARA 7-18 KG 44 ADET	", CategoryId = 5 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/20.jpg" , Description=""},
                    new Product(){ ProductName="MINIES JUNIOR 5 NUMARA 11-25 KG 32 ADET	", CategoryId = 5 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/21.jpg" },



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
