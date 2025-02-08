using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext // DbContext sınıfından miras alınır.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-O1DRK0LF;initial catalog=DbOopCore1;user=sa;Password=kaya96SUM;trustServerCertificate=true");
        }
        public DbSet<Product> Products { get; set; } // Product sınıfı DbSet tipinde products adında sql'de bir tablo oluşturur.
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
