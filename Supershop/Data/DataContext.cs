using Microsoft.EntityFrameworkCore;
using Supershop.Data.Entities;
using System;
using System.Threading.Tasks;

namespace Supershop.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 
        }

        internal Task SaveAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
