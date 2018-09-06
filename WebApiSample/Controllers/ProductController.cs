using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models;
using WebApiSample.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiSample.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductServices _services;

        public ProductController(IProductServices services)
        {
            _services = services;

        }

        [HttpPost]
        [Route("AddProduct")]
        public ActionResult<Product> AddProduct(Product item)
        {
            var productItem = _services.AddProductItem(item);

            if (productItem == null)
                return NotFound();

            return productItem;
            //return Ok(productItem);
        } 

        [HttpGet]
        [Route("GetProduct")]
        public ActionResult<Dictionary<string, Product>> GetProductItems()
        {
            var productItems = _services.GetProductItems();

            if (productItems.Count == 0)
                return NotFound();

            return productItems;
        }
    }
}
