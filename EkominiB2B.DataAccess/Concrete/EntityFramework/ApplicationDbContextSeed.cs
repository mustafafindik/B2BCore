using EkominiB2B.Entities;
using EkominiB2B.Entities.Concrete;
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
                    new Category() { CategoryName = "Android Telefonlar" },
                    new Category() { CategoryName = "Akıllı Saatler" },
                    new Category() { CategoryName = "Akıllı Bileklikler" },
                    new Category() { CategoryName = "Bluetooth Kulaklıklar" },
                    new Category() { CategoryName = "Powerbank" }

                };
                context.Categories.AddRange(category);
                context.SaveChanges();
            }

            if (!context.orderStatuses.Any())
            {
                var orderstatusess = new[] {
                 new OrderStatus() { StatusName = "Hazırlanıyor" },
                 new OrderStatus() { StatusName = "Kargoya Verildi" },
                 new OrderStatus() { StatusName = "Yolda" },
                 new OrderStatus() { StatusName = "Teslim Edildi" },
                 new OrderStatus() { StatusName = "İade Edildi" },
                 new OrderStatus() { StatusName = "İptal Edildi" },

                };
                context.orderStatuses.AddRange(orderstatusess);
                context.SaveChanges();
            }


            if (!context.Products.Any())
            {
                var products = new[]
            {
                    new Product(){ ProductName="Oppo A91 128 GB", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.10,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=2799.15, Image = "/images/Product2/1.jpg",
                        ShortDescription ="Oppo A91 Akıllı Telefonlarda Işık Çağının Kapılarını Aralıyor" ,
                        Description ="Oppo kurulduğu günden bu yana güçlü teknik özellikleri ve şık tasarımıyla dikkat çeken akıllı telefonlar üretiyor. Kullanıcı dostu bir yaklaşımla teknoloji geliştirmeye devam eden Oppo, en ileri teknolojiye sahip akıllı telefon modellerini herkes için ulaşılır kılmak amacıyla çalışmalarını sürdürüyor. Markaya ait A serisi telefonlar da OLED yüksek ekran çözünürlüklü arka kamera ve şık tasarımlarıyla kullanıcılardan büyük ilgi görüyor. Oppo A91 128 GB hem modern ve çekici tasarımı hem de üst düzey donanımı sayesinde bir akıllı telefonla ilgili tüm beklentilerinizi fazlasıyla karşılıyor.."
                    },

                    new Product(){ ProductName="Xiaomi Mi 10T Pro 256 GB", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=true, Price=6988.15, Image = "/images/Product2/2.jpg",
                        ShortDescription ="Xiaomi Mi 10T Pro 256 GB (Xiaomi Türkiye Garantili)",
                        Description ="Xiaomi Mi 10T Pro 256 GB (Xiaomi Türkiye Garantili)"
                    },

                    new Product(){ ProductName="Samsung Galaxy Note 10 Lite 128 GB ", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4000.15, Image = "/images/Product2/3.jpg" ,
                        ShortDescription ="Avucunuzun İçinde Sinematik Bir Ekran",
                        Description ="Samsung, kendine has konsepti sayesinde akıllı telefon tutkunlarının ilgisini çeken Galaxy Note serisini özel bir model ile taçlandırıyor. Samsung Galaxy Note 10 Lite; şık tasarımı ve amiral gemisi özellikleri ile fark yaratırken, S Pen gibi Note serisine has detaylarıyla önceki modellerin genlerini koruyor. Samsung Galaxy Note 10 Lite 128 GB fiyatları açısından ise erişilebilir düzeyde konumlandırılıyor. "
                    },

                    new Product(){ ProductName="Xiaomi Redmi Note 9 Pro 128 GB", CategoryId = 1 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.02,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=3300.15, Image = "/images/Product2/4.jpg" ,
                        ShortDescription ="Zengin Bağlantı Olanakları, Gelişmiş Kameralar, Yerleşik Servis ve Uygulamalar",
                        Description ="Xiaomi'nin efsane amiral gemisi Redmi Note 9 Pro serisi telefon modelleri, güçlü işletim sistemleri, gelişmiş kameraları, zengin bağlantı noktaları, multimedya özellikleri ve uzun ömürlü bataryaları ile tüm gün kesintisiz iletişim olanağının yanı sıra pek çok eğlenceli özellikler sunar. Gün boyu elinizden düşüremeyeceğiniz Redmi Note 9 Pro'nun geniş çaplı ve yüksek çözünürlüklü ekranında film ve video izleyebilir, internette dolaşabilir, bağlantı özellikleriyle veri alışverişi yapabilir, profesyonel netlik ve çözünürlükte fotoğraflar ve videolar çekebilirsiniz. DotDisplay ile simetrik bir ön ve arka tasarıma sahip olan modeller, şık görünümleri ve zengin renk seçenekleriyle göz kamaştırır. "
                    },




                    new Product(){ ProductName="Huawei Watch GT2 46mm Sport Akıllı Saat - Siyah", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=true, Price=1200.15, Image = "/images/Product2/5.jpg" ,
                         ShortDescription ="Dikkat Çekici Tasarım Yüksek Performansla  Huawei Watch GT 2e'de Buluşuyor",
                        Description ="asarımından teknolojik özelliklerine kadar büyük bir titizlikle dizayn edilen Huawei Watch GT 2e, sahip olduğu çok sayıda avantaj ile kullanıcılara bambaşka bir deneyim sunuyor. Hayatı kolaylaştıran işlevsel özelliklere ağırlıklı olarak yer verilen üründe yer alan her bir detay yaşantınızı çok daha keyifli bir hâle getiriyor. "
                    },

                    new Product(){ ProductName="Samsung Galaxy Watch 3 (45mm)", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=1800.15, Image = "/images/Product2/6.jpg"  ,
                          ShortDescription ="Samsung Galaxy Watch 3 (45mm) - Mystic Black - SM-R840NZKATUR (Samsung Türkiye Garantili)",
                        Description ="Samsung Galaxy Watch 3 (45mm) - Mystic Black - SM-R840NZKATUR (Samsung Türkiye Garantili)  "
                    },

                    new Product(){ ProductName="Xiaomi Mi Watch Lite Akıllı Saat - Black", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=412.15, Image = "/images/Product2/7.jpg"  ,
                         ShortDescription ="Xiaomi Mi Watch Lite Akıllı Saat - Black",
                        Description ="Xiaomi Mi Watch Lite Akıllı Saat - Black"
                    },

                    new Product(){ ProductName="Apple Watch Seri 6 44mm GPS Space Gray	", CategoryId = 2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=4000.15, Image = "/images/Product2/8.jpg"  ,
                          ShortDescription ="Apple Watch Seri 6 44mm GPS Space Gray Alüminyum Kasa ve Siyah Spor Kordon M00H3TU/A",
                        Description ="Apple Watch Seri 6 44mm GPS Space Gray Alüminyum Kasa ve Siyah Spor Kordon M00H3TU/A"

                    },

                    new Product(){ ProductName="Apple Watch SE 40mm GPS Space Gray Alüminyum", CategoryId =2 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.1,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=2700.15, Image = "/images/Product2/9.jpg"   ,
                         ShortDescription ="Apple Watch SE 40mm GPS Space Gray Alüminyum",
                        Description ="Apple Watch SE 40mm GPS Space Gray Alüminyum"
                    },

               




                    new Product(){ ProductName="Xiaomi Mi Band 5 Akıllı Bileklik", CategoryId =3 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0.01,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=2004.15, Image = "/images/Product2/16.jpg"  ,
                         ShortDescription ="Göz Alıcı Tasarım Detayları",
                        Description ="Teknoloji konusunda benzersiz ürün tasarımları geliştiren Xiaomi, tasarlamış olduğu yeni nesil akıllı bileklikler ile kaliteli bir deneyim sunuyor. 2020 yılında piyasaya sürülen Xiaomi Mi Band 5, özel manyetik kayış yapısı sayesinde kolunuzdan çıkarmadan şarj edilebilen özelliği ile ön plana çıkıyor. Özellikle şık tasarımı ile dikkat çeken model, spor yaparken tüm detayları kayıt altına alabilmenize ya da gün içerisindeki işlerinizi yönetebilmenize katkıda bulunuyor. Üstün performans ve pratik kullanım detayları ile ön plana çıkan Xiaomi Mi Band 5 modeli, TPU kordonu ve güçlendirilmiş plastik gövdesi ile uzun ömürlü bir kullanımı da beraberinde getiriyor. "
                    },

                    new Product(){ ProductName="Huawei Honor Band 5i Akıllı Bileklik - Siyah", CategoryId = 3 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=234.15, Image = "/images/Product2/17.jpg"  ,
                          ShortDescription ="Farklı kablolar ve şarj cihazlarından sizi özgür kılar. HUAWEI honor bandının dahili USB fişi 5i genel USB şarj cihazlarına uyar, böylece herhangi bir yerde ve herhangi bir zamanda şarj edersiniz. Tek bir şarj, bandı 6 günden fazla kullanım süresiyle güçlendirir.",
                           Description ="Farklı kablolar ve şarj cihazlarından sizi özgür kılar. HUAWEI honor bandının dahili USB fişi 5i genel USB şarj cihazlarına uyar, böylece herhangi bir yerde ve herhangi bir zamanda şarj edersiniz. Tek bir şarj, bandı 6 günden fazla kullanım süresiyle güçlendirir."
                    },



                    new Product(){ ProductName="Apple Airpods Pro Bluetooth Kulaklık MWP22TU/A (Apple Türkiye Garantili)", CategoryId =4 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=false, UpdatedAt = DateTime.Now, IsInSlider=false, Price=2004.15, Image = "/images/Product2/18.jpg"  ,
                         ShortDescription ="Apple Airpods Pro Bluetooth Kulaklık MWP22TU/A (Apple Türkiye Garantili)",
                        Description ="Apple Airpods Pro Bluetooth Kulaklık MWP22TU/A (Apple Türkiye Garantili)"
                    },



                    new Product(){ ProductName="Xiaomi Redmi 20000 Mah Taşınabilir Hızlı Şarj Cihazı - USB-C - 18W 2 Çıkışlı Powerbank - Beyaz", CategoryId =5 ,CreatedBy="Seed" , CreatedAt=DateTime.Now , IsActive=true, DiscountRatio=0,UpdatedBy="Seed", IsFeatured=true, UpdatedAt = DateTime.Now, IsInSlider=false, Price=140.15, Image = "/images/Product2/19.jpg"  ,
                          ShortDescription ="Xiaomi Redmi 20000 Mah Taşınabilir Hızlı Şarj Cihazı - USB-C - 18W 2 Çıkışlı Powerbank - Beyaz",
                        Description ="Xiaomi Redmi 20000 Mah Taşınabilir Hızlı Şarj Cihazı - USB-C - 18W 2 Çıkışlı Powerbank - Beyaz"

                    },

                



                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
            

        }
        public static async Task CreateRootAdmin(IServiceProvider serviceProvider, IConfiguration configuration, IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            var username = configuration["Data:RootUser:username"];
            var email = configuration["Data:RootUser:email"];
            var password = configuration["Data:RootUser:password"];
            var role = configuration["Data:RootUser:role"];


            if (await userManager.FindByNameAsync(username) == null)
            {
                if (await roleManager.FindByNameAsync(role) == null)
                {
                    ApplicationRole adminrole = new ApplicationRole()
                    {
                        Name = role
                    };
                    await roleManager.CreateAsync(adminrole);
                }

                ApplicationUser user = new ApplicationUser()
                {
                    UserName = username,
                    Email = email,
                    Name = "Mustafa",
                    Surname = "Fındık",
                };

                IdentityResult result = await userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    var x = await userManager.AddToRoleAsync(user, role);

                }

            }

        }





    }
}
