using AspNetCoreTestApp.Database.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCoreTestApp.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductAsync();
        Task<Product> GetProductAsync(int id);
        Task<Product> CreateProductAsync(Product entity);
        void UpdateProductColumnAsync(string columnName, object newValue);
        void DeleteAsync(int id);
    }
}
