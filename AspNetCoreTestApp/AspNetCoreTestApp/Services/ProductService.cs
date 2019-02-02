using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTestApp.Common;
using AspNetCoreTestApp.Database;
using AspNetCoreTestApp.Database.Models;

namespace AspNetCoreTestApp.Services
{
    public class ProductService : IProductService
    {
        public ProductService(DatabaseContext context, AppSettings settings)
        {
            Context = context;
            AppSettings = settings;
        }

        private DatabaseContext Context { get; set; }
        private AppSettings AppSettings { get; set; }

        public Task<Product> CreateProductAsync(Product entity)
        {
            // CreateAsync invoke
            throw new NotImplementedException();
        }
        
        public void DeleteAsync(int id)
        {
            //Context.Products.Remove()
        }

        public Task<List<Product>> GetAllProductAsync()
        {
            //  GetAllAsync<Product>() fromContext
            throw new NotImplementedException();
        }

        public Task<Product> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductColumnAsync(string columnName, object newValue)
        {
            throw new NotImplementedException();
        }

        private double TotalPriceWithVAT(Product product, double VAT)
        {
            return product.Price* product.Unit*VAT;
        }
    }
}
