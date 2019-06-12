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
                    new Product(){ ProductName="MIGROS TUZLU FISTIK 200 G", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.10,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/1.jpg",
                        ShortDescription ="Migros Tuzlu Fıstık sohbetlerinize lezzet katar." ,
                        Description ="Migros Tuzlu Fıstık sohbetlerinize lezzet katar. Tazecik tuzlu fıstığı misafirlerinize ikram edebilir, evde, parkta, istediğiniz her yerde tüketebilirsiniz. Migros kalite ve güvencesi ile üretilip paketlenmiş olan çerezi arzu ettiğiniz diğer çerezlerle karıştırarak ya da tek başına sunabilirsiniz. Yaklaşık 10 porsiyondan oluşmaktadır."
                    },

                    new Product(){ ProductName="MIGROS KAVRULMUŞ FINDIK 200 G	", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=true, Price=4.15, Image = "/images/Product/2.jpg",
                        ShortDescription ="Kavrulmuş Fındık, enfes kavrulmuş lezzeti ile atıştırmalık bir şeyler istediğiniz zamanlar için birebir. ",
                        Description ="Kavrulmuş Fındık, enfes kavrulmuş lezzeti ile atıştırmalık bir şeyler istediğiniz zamanlar için birebir. Besleyici yağ içeriği ile fındığı çeşitli kuru yemiş ve meyvelerle bir arada tüketebilir, kalabalık buluşmalarda atıştırmalık olarak servis edebilirsiniz."
                    },

                    new Product(){ ProductName="MIGROS KARIŞIK KURUYEMİŞ 200 G	", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/3.jpg" ,
                        ShortDescription ="Migros Karışık Kuru Yemiş, farklı çerezlerin oluşturduğu bir karışımdır. ",
                        Description ="Migros Karışık Kuru Yemiş, farklı çerezlerin oluşturduğu bir karışımdır. Antep fıstığı, leblebi, beyaz leblebi, fıstık, kabak çekirdeği ve fındık karışımından oluşuyor. Bu lezzetli karışımı misafirlerinize ikram edebilir, evde, parkta, istediğiniz her yerde tüketebilirsiniz."
                    },

                    new Product(){ ProductName="MIGROS BEYAZ LEBLEBİ 200 G	", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.02,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/4.jpg" ,
                        ShortDescription ="Migros Beyaz Leblebi, sohbetlerinize lezzet katar.",
                        Description ="Migros Beyaz Leblebi, sohbetlerinize lezzet katar.Tazecik beyaz leblebileri misafirlerinize ikram edebilir, evde, parkta, istediğiniz her yerde tüketebilirsiniz. Migros kalite ve güvencesi ile üretilip paketlenmiş olan paket, yaklaşık 7 porsiyondan oluşmaktadır. "
                    },

                    new Product(){ ProductName="MİGROS PİLAVLIK İTHAL PİRİNÇ 1000 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=true, Price=4.15, Image = "/images/Product/5.jpg" ,
                         ShortDescription ="Migros Pilavlık İthal Pirinç'in orta büyüklükteki taneleri ile leziz bir pilav hazırlayabilirsiniz. ",
                        Description ="Migros Pilavlık İthal Pirinç'in orta büyüklükteki taneleri ile leziz bir pilav hazırlayabilirsiniz. Farklı pilav tariflerine de uygun olan bu pirinç, et ya da sebze yemeklerinin yanına çok yakışır. "
                    },

                    new Product(){ ProductName="MİGROS BALDO PİRİNÇ 1000 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/6.jpg"  ,
                          ShortDescription ="Migros Baldo Pirinç, Migros kalite ve güvencesiyle üretilir.",
                        Description ="Migros Baldo Pirinç, Migros kalite ve güvencesiyle üretilir. İri taneli ve kokusuz olması ile pilav yapımında ya da yemeklerin içinde sıklıkla tercih edilir. Türk mutfağında vazgeçilmez bir yeri olan pirinçle pilav çeşitlerinin yanı sıra; sarma, sütlaç yapabilir birçok çorbanın içine karıştırabilirsiniz. "
                    },

                    new Product(){ ProductName="MİGROS DERMASON KURU FASULYE 1000 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/7.jpg"  ,
                         ShortDescription ="Migros Dermason Kuru Fasulye, Migros kalite ve güvencesiyle üretilir.",
                        Description ="Migros Dermason Kuru Fasulye, Migros kalite ve güvencesiyle üretilir. Kuru fasulyenin en lezzetli halini sofranıza getirir.Sofraların vazgeçilmez lezzetlerinden biri olan kuru fasulye, kuş başı et, sucuk ya da pastırma gibi et ürünleri ile ağır ağır pişirildiğinde doyurucu ve leziz bir yemek olabilir."
                    },

                    new Product(){ ProductName="MİGROS KIRMIZI MERCİMEK 1000 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/8.jpg"  ,
                          ShortDescription ="Migros Kırmızı Mercimek normal sürede tam olarak pişer, pişerken dağılmaz. Besin değeri oldukça yüksek olan kırmızı mercimek vücuda ve zihne güç verir. Nemden uzak olması şartıyla kırmızı mercimek uzun süre muhafaza edilebilmektedir. ",
                        Description ="Migros bakliyat ürünleri; özenle seçilen, kalitesi ve boyutları yüksek standartlara sahip ürünlerdir. Aynı yörelerden alınmaları ürünlerin lezzet standardını sağlar. Temizleme, işlenme ve kalibrasyonu yüksek teknolojiye sahip tesislerde özenle yapılır.Fabrika içindeki sistemlerde ürün, üretim sürecinde, ürünün temizlenmesi işlenmesi ve kalibrasyonlara ayrılması süreçleri, her malda farklılık gösterir ve her mal için özelliklerine göre, ayrı makine hatları kullanılır. Mevcut kullanılan hatların oluşturduğu makine parkları son teknolojiye sahiptir. Üretim aşamaları 30 yıllık tecrübesi ile ortaya çıkan bir sistem bütünlüğüne sahiptir.Doğrudan üreticiden, tarladan gelen tüm bakliyat, fasulye, pirinç ve bulgur ürünleri için mal işleme sırası ana hatları ile şöyledir: Ön elemeden geçirilerek kaba temizlik yapılır(çöp toz v.s.). Elekten geçirilerek kalibrasyonları sağlanır(farklı çaplarda)Taş ayıklama makineleri ile ürün, taşlardan arındırılır. Hafif tane ayıklama makineleri ile delikli, boş ve hasarlı taneler ayrılır. Sortex makinelerden geçirilerek ürün, renkli, çizgili ve lekeli tanelerden temizlenir. Temizlenmiş işlenmiş kalibrasyonuna ayrılmış tertemiz ürün elde edilir. Ürünler aynı yörelerden alınan ürünlerdir ve tarım ürünü olmasına rağmen(kuraklık verim kaybı gibi doğaya bağlı etkenler) 12 ay boyunca standartlar korunmaktadır."
                    },

                    new Product(){ ProductName="MIGROS TOZ ŞEKER 1 KG	", CategoryId =2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.1,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/9.jpg"   ,
                         ShortDescription ="Migros Toz Şeker, %100 şeker pancarından üretiliyor. ",
                        Description ="Migros Toz Şeker, %100 şeker pancarından üretiliyor. El değmeden paketleniyor. Her türlü tatlıda ve tatlandırılmak istenilen içeceklerde rahatlıkla kullanılabilir. Rengi bembeyaz, kolay çözünür."
                    },

                    new Product(){ ProductName="MİGROS AYÇİÇEK YAĞI 1 L	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/10.jpg"  ,
                        ShortDescription ="Migros Ayçiçek Yağı, açık rengi, berrak görüntüsü ve doğal tadı ile farklılaşıyor.",
                        Description ="Migros Ayçiçek Yağı, açık rengi, berrak görüntüsü ve doğal tadı ile farklılaşıyor. Bu ürünü kullanan tüketiciler* ürünün son derece hafif olduğunu, kızartmaları yağ çekmeden çıtır çıtır yaptığını düşünüyor.Sıvı yağları; ışık görmeyen, oda sıcaklığında olan bir yerde nemden uzakta ve ağzı kapalı şekilde muhafaza etmeye özen gösterin."
                    },

                    new Product(){ ProductName="MİGROS FİYONK MAKARNA 500 GR	", CategoryId =2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=true, Price=4.15, Image = "/images/Product/11.jpg"   ,
                          ShortDescription ="Migros Fiyonk Makarna, ismini şeklinden alan, lezzetli bir makarna cinsidir. Fiyonk makarna özellikle kıymalı soslarla çok yakışır. ",
                        Description ="Migros Fiyonk Makarna, ismini şeklinden alan, lezzetli bir makarna cinsidir. Fiyonk makarna özellikle kıymalı soslarla çok yakışır. Makarnanızı her zamankinden farklı bir şekilde sunmak isterseniz, haşladığınız makarnayı soğuttuktan sonra salatalarınıza katabilirsiniz. Böylece salataları daha besleyici hale getirebilirsiniz. "
                    },

                    new Product(){ ProductName="MİGROS SPAGETTİ MAKARNA 500 GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=true, Price=4.15, Image = "/images/Product/12.jpg"   ,
                         ShortDescription ="Migros Spagetti Makarna, İtalyan mutfağının en sevilen lezzetini sofralarınıza getiriyor. ",
                        Description ="Migros Spagetti Makarna, İtalyan mutfağının en sevilen lezzetini sofralarınıza getiriyor. Lezzetli mi lezzetli, tam kıvamında bir spagetti için pakette belirtilen pişirme talimatlarını uygulayabilir, çeşitli soslarla makarnanızı çok daha lezzetli kılabilirsiniz. "
                    },

                    new Product(){ ProductName="MİGROS BURGU MAKARNA 500GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.05,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/13.jpg"  ,
                          ShortDescription ="Migros Burgu Makarna, lezzetli ve pratik öğünlerin vazgeçilmez lezzeti makarna, Migros kalitesi ile sizinle buluşuyor. ",
                        Description ="Farklı soslarla denediğinizde lezzetine lezzet katacağınız burgu makarna ile İtalyan mutfağının en özel tariflerini deneyebilir ya da geleneksel tariflerle sofranızı taçlandırabilirsiniz. "
                    },

                    new Product(){ ProductName="MİGROS ARPA ŞEHRİYE 500GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/14.jpg"  ,
                          ShortDescription ="Migros Arpa Şehriye, pilavlara ve çorbalara çok yakıştığı gibi, yalnız başına da tüketilebilir. ",
                        Description ="Migros Arpa Şehriye, pilavlara ve çorbalara çok yakıştığı gibi, yalnız başına da tüketilebilir. Arpa şehriyeyi aynı pilav gibi pişirebilir, içine çeşitli sebzeler ekleyerek lezzetini katlayabilirsiniz. Arpa şehriye pilavı özellikle et yemekleri ile çok yakışıyor. "
                    },

                    new Product(){ ProductName="MİGROS TEL ŞEHRİYE 500GR	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.04,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=true, Price=4.15, Image = "/images/Product/15.jpg"   ,
                          ShortDescription ="Migros Tel Şehriye, pilavların ve çorbaların olmazsa olmaz lezzetlerindendir. ",
                        Description ="Migros Tel Şehriye, pilavların ve çorbaların olmazsa olmaz lezzetlerindendir. Tel şehriyeyi her zaman alıştığınız gibi tavuk çorbasına katabilir ya da farklı çorba tariflerine ekleyerek, yumuşak bir kıvam elde edebilirsiniz. "
                    },

                    new Product(){ ProductName="MİGROS ÇİKOLATA KAPLAMALI SANDVİÇ 30G	", CategoryId =3 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.01,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/16.jpg"  ,
                         ShortDescription ="Migros Çikolata Kaplamalı Sandviç çikolata arası bisküviyi sevenlerin tercihidir.",
                        Description ="Migros Çikolata Kaplamalı Sandviç çikolata arası bisküviyi sevenlerin tercihidir.Bisküvilerin tazeliğini koruması için nemden uzak ağzı sıkı kapatılmış bir şekilde serin ve kuru bir yerde saklamalısınız. "
                    },

                    new Product(){ ProductName="MIGROS KAKAO KREMALI SANDVİÇ BİSKÜVİ 10'LU 300 G	", CategoryId = 3 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/17.jpg"  ,
                          ShortDescription ="Migros Çikolata Kaplamalı Sandviç çikolata arası bisküviyi sevenlerin tercihidir.",
                        Description ="Migros Çikolata Kaplamalı Sandviç çikolata arası bisküviyi sevenlerin tercihidir.Bisküvilerin tazeliğini koruması için nemden uzak ağzı sıkı kapatılmış bir şekilde serin ve kuru bir yerde saklamalısınız. "
                    },
               
                    new Product(){ ProductName="MİGROS RİZE ÇAY 1000 G	", CategoryId =4 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/18.jpg"  ,
                         ShortDescription ="Migros Rize Çay Rize'nin en taze ve en güzel çay filizlerinden elde edilir. Tamamen doğal olan bu ürün, hoş bir kokuya sahiptir ve damakta güzel bir lezzet bırakır. ",
                        Description ="Migros Rize Çay Rize'nin en taze ve en güzel çay filizlerinden elde edilir. Tamamen doğal olan bu ürün, hoş bir kokuya sahiptir ve damakta güzel bir lezzet bırakır.Demlemede taze, kireçsiz su ve porselen demlik tercih edin. Demleyeceğiniz miktara göre her bardak çay için bir çay kaşığı Migros Çay koyun. Demliği kaynayan su üzerinde ısıttıktan sonra taze kaynamış suyu ilave edin. Demini alması için kaynayan suyun üzerinde 10-15 dakika bekletin. Demlenen çayınızı lezzetini kaybetmeden için."
                    },

                    new Product(){ ProductName="MİGROS 72 Lİ ISLAK HAVLU	", CategoryId =5 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/19.jpg"  ,
                          ShortDescription ="Migros Islak Havlu, bebeklerin hassas cildine özel olarak formülize edilmiştir. ",
                        Description ="Migros Islak Havlu, bebeklerin hassas cildine özel olarak formülize edilmiştir. Yumuşacık dokusu ile hassas bir temizlik sağlar. Alt değiştirme esnasında popo temizliği için, mama yedirirken bebeğin ellerini, yüzünü temizlemek için kullanılabilir. "
                    },

                    new Product(){ ProductName="MINIES MAXI 4 NUMARA 7-18 KG 44 ADET	", CategoryId = 5 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4.15, Image = "/images/Product/20.jpg" ,
                          ShortDescription ="Minies 4 No Maxi Bebek Bezi 7-18 kg., uzun süre kuru kalmaya yardımcı hassas yüzeye ve ergonomik bir yapıya sahiptir. ",
                        Description ="Minies 4 No Maxi Bebek Bezi 7-18 kg., uzun süre kuru kalmaya yardımcı hassas yüzeye ve ergonomik bir yapıya sahiptir. Minies bebek bezi, bebeğinizi huzurlu sizi mutlu kılacak. "
                    },

                    new Product(){ ProductName="MINIES JUNIOR 5 NUMARA 11-25 KG 32 ADET	", CategoryId = 5 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=true, Price=4.15, Image = "/images/Product/21.jpg" ,
                        ShortDescription ="Minies 5 No Junior Bebek Bezi 11-25 kg., kuru, hassas yüzeyi ile bebeğinizin konforlu hissetmesini sağlar. ",
                        Description ="Minies 5 No Junior Bebek Bezi 11-25 kg., kuru, hassas yüzeyi ile bebeğinizin konforlu hissetmesini sağlar. Esnek yan bantlar ve hassas yüzeyi ile bebeğinizin hareketlerini kısıtlamadan yüksek koruma sağlar. "
                    },



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
