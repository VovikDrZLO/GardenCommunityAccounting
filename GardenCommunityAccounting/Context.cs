using GardenCommunityAccounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GardenCommunityAccounting
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Land> Lands { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<ElectricBill> ElectricBill { get; set; }
        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddXmlFile(@"appsettings.xml");
            var config = builder.Build();
            string connectionString = config.GetValue<string>("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Land>().HasData(InitLandData());
            modelBuilder.Entity<DocumentType>().HasData(InitDocTypeData());
        }
        private List<Land> InitLandData()
        {
            var result = new List<Land>();
            for(int cnt = 0; cnt < 320; cnt++)
            {
                result.Add(new Land { Id = Guid.NewGuid(), Number = cnt });
            }
            return result;
        }
        private List<DocumentType> InitDocTypeData()
        {
            var result = new List<DocumentType>
            {
                new DocumentType { Id = Guid.NewGuid(), Name = "Електроенергія", IsIncome = true },
                new DocumentType { Id = Guid.NewGuid(), Name = "Податок на землю", IsIncome = true },
                new DocumentType { Id = Guid.NewGuid(), Name = "Цільовий внесок", IsIncome = true }
            };
            return result;
        }
    }
}
