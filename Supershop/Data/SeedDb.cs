using Supershop.Data.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Supershop.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        private Random _random;

        public SeedDb(DataContext context)
        {
            _context = context;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Products.Any())
            {
                AddProduct("Lego Technic Bugatti Chiron");
                AddProduct("Lego Technic Fiat 500");
                AddProduct("Lego Technic Vespa Primavera");
                AddProduct("Lego Technic BMW M1000RR");
                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name)
        {
            _context.Add(new Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(100),
            });
        }
    }
}
