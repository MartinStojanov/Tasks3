using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task3.Models;

namespace Task3.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

            public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult List()
        {
            IEnumerable<Product> allProducts = productRepository.AllProducts.OrderBy(p => p.ProductID);
            return View(allProducts);
        }
    }
}
