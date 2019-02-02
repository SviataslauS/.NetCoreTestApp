using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTestApp.Models;
using Microsoft.AspNetCore.Authorization;
using AspNetCoreTestApp.Services;
using AspNetCoreTestApp.Database.Models;
using AspNetCoreTestApp.Database;
using AspNetCoreTestApp.Common;

namespace AspNetCoreTestApp.Controllers
{
    [Authorize]
    [ApiController]
    public class ProductController : Controller
    {
        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }

        private DatabaseContext Context { get; set; }
        private AppSettings AppSettings { get; set; }

        public IProductService ProductService { get; set; }

        public Task<List<Product>> GetAll()
        {
            return ProductService.GetAllProductAsync();
        }
        
    }
}
