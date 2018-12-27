namespace HousewareShop.Data.Migrations
{
    using HousewareShop.Common;
    using HousewareShop.Model;
    using HousewareShop.Model.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HousewareShop.Data.HousewareShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HousewareShop.Data.HousewareShopDbContext context)
        {
            CreateProductCategorySample(context);
            CreateSlide(context);
            //  This method will be called after migrating to the latest version.
            CreatePage(context);
            CreateContactDetail(context);

            CreateConfigTitle(context);
        }


        private void CreateConfigTitle(HousewareShopDbContext context)
        {
            if (!context.SystemConfigs.Any(x => x.Code == "HomeTitle"))
            {
                context.SystemConfigs.Add(new SystemConfig()
                {
                    Code = "HomeTitle",
                    ValueString = "Trang chủ Hoàng Việt",

                });
            }
            if (!context.SystemConfigs.Any(x => x.Code == "HomeMetaKeyword"))
            {
                context.SystemConfigs.Add(new SystemConfig()
                {
                    Code = "HomeMetaKeyword",
                    ValueString = "Trang chủ Hoàng Việt",

                });
            }
            if (!context.SystemConfigs.Any(x => x.Code == "HomeMetaDescription"))
            {
                context.SystemConfigs.Add(new SystemConfig()
                {
                    Code = "HomeMetaDescription",
                    ValueString = "Trang chủ Hoàng Việt",

                });
            }
        }
        private void DbContextSeed(HousewareShopDbContext context, int retry = 0)
        {
            int retryForAvaiability = retry;
            try
            {
                CreateProductCategorySample(context);
            }
            catch (Exception)
            {
                if (retryForAvaiability < 10)
                {
                    retryForAvaiability++;

                    DbContextSeed(context, retryForAvaiability);
                }
            }
        }
        private void CreateUser(HousewareShopDbContext context)
        {
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new HousewareShopDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new HousewareShopDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "phamchien",
            //    Email = "phamchien96nd@gmail.com",
            //    EmailConfirmed = true,
            //    //BirthDay = DateTime.Now,
            //    FullName = "Technology Education"

            //};

            //manager.Create(user, "123654$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("phamchien96nd@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
        private void CreateSlide(HousewareShopDbContext context)
        {
            if (context.Slides.Count() == 0)
            {
                List<Slide> listSlide = new List<Slide>()
                {
                    new Slide() {
                        Name ="Slide 1",
                        DisplayOrder =1,
                        Status =true,
                        Url ="#",
                        Image ="/Assets/client/images/bag1.jpg",
                        Content =@"	<h2>FLAT 50% 0FF</h2>
                                <label>SẮM TẾT <b>THẢ GA</b></label>
                                <p>Ủ ấm hạnh phúc mọi gia đình </ p >
                        " },
                    new Slide() {
                        Name ="Slide 2",
                        DisplayOrder = 2,
                        Status =true,
                        Url ="#",
                        Image ="/Assets/client/images/bag1.jpg",
                    Content=@"<h2>FLAT 50% 0FF</h2>
                               <label>SẮM TẾT <b>THẢ GA</b></label>
                                <p> Ủ ấm hạnh phúc mọi gia đình </ p >
                                "},
                };
                context.Slides.AddRange(listSlide);
                context.SaveChanges();
            }
        }
        private void CreateProductCategorySample(HousewareShop.Data.HousewareShopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name="Điện lạnh",Alias="dien-lanh",Status=true },
                 new ProductCategory() { Name="Viễn thông",Alias="vien-thong",Status=true },
                  new ProductCategory() { Name="Đồ gia dụng",Alias="do-gia-dung",Status=true },
                   new ProductCategory() { Name="Mỹ phẩm",Alias="my-pham",Status=true }
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }

        }
        private void CreateFooter(HousewareShopDbContext context)
        {
            if (context.Footers.Count(x => x.ID == CommonConstants.DefaultFooterId) == 0)
            {
                string content = "";
            }
        }
        private void CreatePage(HousewareShopDbContext context)
        {
            if (context.Pages.Count() == 0)
            {
                try
                {
                    var page = new Page()
                    {
                        Name = "Giới thiệu",
                        Alias = "gioi-thieu",
                        Content = @"Cửa hàng gia dụng Hoàng Việt :
</br>
- Phân phối sỉ lẻ các mặt nhựa gia dụng : bàn nhựa , ghế nhựa , thùng đá nhựa ...
</br>
- Cung cấp sỉ lẻ các loại bàn ghế inox 201 , 304 với giá cạnh tranh , chất lượng đảm bảo 
</br>
- Phân phối sỉ lẻ các loại bàn ghế cafe : ghế cafe inox xếp vải bố , bàn ghế cafe giả mây.
</br>
- Nhà cung cấp các loại võng xếp : Duy Lợi , Duy Phương , Chấn Thái Sơn , Tín Thành .
</br>
- Bán các loại tô chén dĩa sứ , melamine , nhựa .
</br>
- Phân phối sỉ lẻ các loại ghế bố , giường xếp , giường gấp .",
                        Status = true

                    };
                    context.Pages.Add(page);
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                    }
                }

            }
        }
        private void CreateContactDetail(HousewareShopDbContext context)
        {
            if (context.ContactDetails.Count() == 0)
            {
                try
                {
                    var contactDetail = new HousewareShop.Model.ContactDetail()
                    {
                        Name = "Gia dụng Hoàng Việt",
                        Address = "156 đường số 17 , phường Tân Kiểng , Quận 7 , TP. HCM",
                        Email = "giadunghoangviet@gmail.com",
                        Lat = 21.0633645,
                        Lng = 105.8053274,
                        Phone = "01677821696",
                        Website = "https://giadunghoangviet.com",
                        Other = "",
                        Status = true

                    };
                    context.ContactDetails.Add(contactDetail);
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation error.");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                    }
                }

            }
        }
    }
}
