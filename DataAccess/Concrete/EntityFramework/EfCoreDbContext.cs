using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = COMPUTER\NICATRED; Database = ManatAz; Trusted_Connection = True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NeedyPerson>()
                .HasOne(a => a.CarouselItem).WithOne(b => b.NeedyPerson)
                .HasForeignKey<CarouselItem>(c => c.NeedyPersonId)
                .OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NeedyPersonInfo>()
                .HasOne(a => a.NeedyPerson).WithOne(b => b.NeedyPersonInfo)
                .HasForeignKey<NeedyPerson>(c => c.NeedyPersonInfoId)
                .OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<NeedyPersonInfo> NeedyPersonInfos { get; set; }
        public DbSet<AboutOptions> AboutOptions { get; set; }
        public DbSet<CarouselItem> CarouselItems { get; set; }
        public DbSet<Causes> Causes { get; set; }
        public DbSet<NeedyPerson> NeedyPersons { get; set; }
        public DbSet<SiteOptions> SiteOptions { get; set; }
        public DbSet<User> User { get; set; }
      
    }
}
