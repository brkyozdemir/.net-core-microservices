using Ecommerce.Api.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Products.Interfaces
{
    public interface IProductsProvider
    {
        Task<(bool IsSucces, IEnumerable<Product> Products, string ErrorMessage)> GetProductsAsync();
        Task<(bool IsSucces, Product Product, string ErrorMessage)> GetProductAsync(int id);

    }
}
