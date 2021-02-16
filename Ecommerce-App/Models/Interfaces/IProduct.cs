using Ecommerce_App.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Models.Interfaces
{
    public interface IProduct
    {
        Task<Product> Create(ProductDTO Product);
        Task<ProductDTO> GetProduct(int id);
        Task<List<ProductDTO>> GetCategories();
        Task<Product> UpdateProduct(int id, ProductDTO Product);
        Task DeleteProduct(int id);
    }
}
