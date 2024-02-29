using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace WeDriveRental.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<RentalModel>? Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RentalModel>().HasData(
                new RentalModel()
                {
                    Id = 1,
                    Brand = "Mercedes-Benz",
                    Model = "Citan",
                    Color = "Red",
                    IsRented = false,
                    Price = 1199.99,
                    Year = 2018,
                    ImageUrl = "https://www.mercedes-benz.se/content/sweden/sv/vans/models/citan/4206-xz0/overview/_jcr_content/root/responsivegrid/tabs_copy/tabitem/hotspot_module/hotspot_simple_image.component.damq1.3361326377869.jpg/mercedes-benz-citan-panel-van-pi-pages-overview-SSPIP144537_3302x1858-03-2023.jpg"
                },
                new RentalModel()
                {
                    Id = 2,
                    Brand = "GX",
                    Model = "Lexus",
                    Color = "Black",
                    IsRented = false,
                    Price = 2499.99,
                    Year = 2010,
                    ImageUrl = "https://global.toyota/pages/news/images/2023/06/09/0900_GX/001.jpg"
                },
                new RentalModel()
                {
                    Id = 3,
                    Brand = "BMW",
                    Model = "M3",
                    Color = "Dark-blue",
                    IsRented = false,
                    Price = 3999.99,
                    Year = 2021,
                    ImageUrl = "https://www.topgear.com/sites/default/files/news-listicle/image/voodoo.jpg"
                },
                new RentalModel()
                {
                    Id = 4,
                    Brand = "Volvo",
                    Model = "V70",
                    Color = "Red",
                    IsRented = false,
                    Price = 599.99,
                    Year = 2006,
                    ImageUrl = "https://images.autouncle.com/se/car_images/93d5d900-ebb1-414a-a76d-ccc3936c5552_volvo-v70-2-5ft-drive-geartronic-momentum-r-design-adaptiv.jpg"
                },
                new RentalModel()
                {
                    Id = 5,
                    Brand = "Toyota",
                    Model = "RAV4",
                    Color = "Grey",
                    IsRented = false,
                    Price = 399.98,
                    Year = 2015,
                    ImageUrl = "https://kong-proxy-intranet.toyota-europe.com/c1-images/resize/ccis/1280x1280/zip/se/configurationtype/visual-for-grade-selector/product-token/55c5bab7-85ef-41cf-b576-18a5347b8b73/grade/569705cd-d15a-463a-8050-7d9cbdc718a8/body/30b0ef55-504f-4ce5-8f54-6856b2e8aa20/fallback/true/padding/50,50,50,50/image-quality/70/day-exterior-4.png"
                },
                new RentalModel()
                {
                    Id = 6,
                    Brand = "Honda",
                    Model = "Civic",
                    Color = "White",
                    IsRented = false,
                    Price = 750.00,
                    Year = 2012,
                    ImageUrl = "https://vehicle-images.dealerinspire.com/dcde-110007549/JHMFL5G44RX000285/ece0f414a9f0780842a14e0a334a738a.png"
                });
        }
    }
}
