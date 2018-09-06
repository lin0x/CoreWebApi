using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSample.Models;

namespace WebApiSample.Services
{
    public interface IProductServices
    {
        Product AddProductItem(Product item);
        Dictionary<string, Product> GetProductItems();
    }
}
