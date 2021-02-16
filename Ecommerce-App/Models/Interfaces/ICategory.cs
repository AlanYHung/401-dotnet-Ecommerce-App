using Ecommerce_App.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Models.Interfaces
{
    public interface ICategory
    {
        Task<Category> Create(CategoryDTO Category);
        Task<CategoryDTO> GetCategory(int id);
        Task<List<CategoryDTO>> GetCategories();
        Task<Category> UpdateCategory(int id, CategoryDTO Category);
        Task DeleteCategory(int id);
        Task AddProduct(int CategoryId, int ProductId);
        Task RemoveProduct(int CategoryId, int ProductId);

    }
}
