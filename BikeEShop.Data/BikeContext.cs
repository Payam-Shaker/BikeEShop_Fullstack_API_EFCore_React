using BikeEShop.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace BikeEShop.Data
{
    public class BikeContext : DbContext
    {

        public BikeContext()
        { }
        public BikeContext(DbContextOptions<BikeContext> options) :base(options)
        { }

        public DbSet<Bike> Bikes { get; set; }


    }
}
