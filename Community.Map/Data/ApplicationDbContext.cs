using System;
using System.Collections.Generic;
using System.Text;
using Community.Map.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Community.Map.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<HelpRequest> HelpRequests { get; set; }
        public DbSet<HelpOffer> HelpOffers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed help offers

            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 4,
                Name = "Boots",
                Phone = "01423 863171",
                Email = "no email",
                Latitude = 54.008198,
                Longitude = -1.467082,
                Category = HelpCategory.Medication,
                Notes = "Chemist"
            });
            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 5,
                Name = "Lloyds Pharmacy",
                Phone = "01423 865308",
                Email = "no email",
                Latitude = 54.008220,
                Longitude = -1.466155,
                Category = HelpCategory.Medication,
                Notes = "Chemist"
            });
            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 6,
                Name = "Naylor P R Chemist",
                Phone = "01423 862117",
                Email = "no email",
                Latitude = 54.008101,
                Longitude = -1.467649,
                Category = HelpCategory.Medication,
                Notes = "Chemist"
            });

            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 7,
                Name = "Chain Line Pharmacy",
                Phone = "01423 864312",
                Email = "no email",
                Latitude = 54.011491,
                Longitude = -1.456118,
                Category = HelpCategory.Medication,
                Notes = "Chemist"
            });
            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 8,
                Name = "Boots Retail Park",
                Phone = "01423 860197",
                Email = "no email",
                Latitude = 54.000013,
                Longitude = -1.443910,
                Category = HelpCategory.Medication,
                Notes = "Chemist"
            });
            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 9,
                Name = "Honey Bees",
                Phone = "01423 866730",
                Email = "no email",
                Latitude = 54.009190,
                Longitude = -1.461660,
                Category = HelpCategory.Shopping,
                Notes = "DELIVER: Home cooked meals / veg / cakes"
            });
            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 10,
                Name = "The Farm Dairy",
                Phone = "01423 865027",
                Email = "no email",
                Latitude = 54.007747,
                Longitude = -1.466392,
                Category = HelpCategory.Shopping,
                Notes = "DELIVER: Bread / Eggs / Milk / Cooked Meats"
            });
            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 11,
                Name = "The Wine Shop",
                Phone = "01423 869940",
                Email = "no email",
                Latitude = 54.008173,
                Longitude = -1.467046,
                Category = HelpCategory.Shopping,
                Notes = "DELIVER: Wine / Beer / Spirits"
            });
            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 13,
                Name = "Knaresborough Delivers",
                Phone = "01423 869918",
                Email = "no email",
                Latitude = 54.007877,
                Longitude = -1.467823,
                Category = HelpCategory.Shopping,
                Notes = "DELIVER: Meat / Veg / Bread / Milk / Eggs / Cheese",
                WebAddress = "https://knaresboroughdelivers.com "
            });
            modelBuilder.Entity<HelpOffer>().HasData(new HelpOffer
            {
                Id = 14,
                Name = "Huttons Butchers",
                Phone = "01423 863122",
                Email = "no email",
                Latitude = 54.00726,
                Longitude = -1.46727,
                Category = HelpCategory.Shopping,
                Notes = "DELIVER: Meat",
                WebAddress = "https://www.huttonsbutchers.com/"
            });
        }
    }
}
