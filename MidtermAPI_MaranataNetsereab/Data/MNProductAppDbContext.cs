using Microsoft.EntityFrameworkCore;
using MidtermAPI_MaranataNetsereab.Model;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MidtermAPI_MaranataNetsereab.Data {
    public class MNProductAppDbContext : DbContext {
        //public MNProduct() { }

        public MNProductAppDbContext(DbContextOptions<MNProductAppDbContext> options) : base(options) { }

        public DbSet<MNProduct> Products { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //    base.OnModelCreating(modelBuilder);
        //    SeedData(modelBuilder);
        //}

        //private static void SeedData(ModelBuilder modelBuilder) {
        //    modelBuilder.Entity<MNProduct>().HasData(
        //        new MNProduct { Id = 1, Name = "Laptop" },
        //        new MNProduct { Id = 2, Name = "Mouse"},
        //        new MNProduct { Id = 3, Name = "Keyboard"}
        //    );
        //}
    }
}