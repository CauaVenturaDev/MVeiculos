using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVeiculos.Modelos;

namespace MVeiculos.Banco
{
    public class MVeiculosContext : DbContext
    {
        public DbSet<Car>? Cars { get; set; }
        public DbSet<Brand>? Brands { get; set; }
        public DbSet<Client>? Clients { get; set; }


        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"MVeiculos\";Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
