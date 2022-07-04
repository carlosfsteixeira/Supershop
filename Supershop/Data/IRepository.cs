using Supershop.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supershop.Data
{
    public interface IRepository
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts();
        bool ProductExists(int id);
        Task<bool> SaveAllAsync();
        void UpdateProduct(Product product);
    }
}