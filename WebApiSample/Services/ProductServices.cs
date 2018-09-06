using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSample.Models;

namespace WebApiSample.Services
{
    public class ProductServices : IProductServices
    {
        private readonly Dictionary<string, Product> _productItems;

        public ProductServices()
        {
            _productItems = new Dictionary<string, Product>();
        }

        public Product AddProductItem(Product item)
        {
            _productItems.Add(item.ProductName, item);
            return item;
        }

        public Dictionary<string, Product> GetProductItems()
        {
            return _productItems;
        }
    }
}
