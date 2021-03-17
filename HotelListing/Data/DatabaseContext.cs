using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options)
        {}        
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Nepal",
                    ShortName = "NP"
                },
                new Country
                {
                    Id = 2,
                    Name = "United States of America",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 3,
                    Name = "England",
                    ShortName = "ENG"
                }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Marriot",
                    Address = "Kathmandu",
                    CountryID = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hilton",
                    Address = "New York",
                    CountryID = 2,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Novotel",
                    Address = "London",
                    CountryID = 3,
                    Rating = 4.6
                }
                );
        }
    }
}
