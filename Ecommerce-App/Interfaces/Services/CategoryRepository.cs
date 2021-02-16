using Ecommerce_App.Data;
using Ecommerce_App.Models.API;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Models.Interfaces.Services
{
  public class CategoryRepository : ICategory
  {
    private ECommerceDbContext _context;

    /// <summary>
    /// Constructor connects to sql database
    /// </summary>
    /// <param name="context">sql database</param>
    public CategoryRepository(ECommerceDbContext context)
    {
      _context = context;
    }

    /// <summary>
    /// POST Method to SQL Server
    /// </summary>
    /// <param name="Category">Category Object to Add into Sql Table</param>
    /// <returns></returns>
    public async Task<Category> CreateCategory(CategoryDTO Category)
    {
      Category newCategory = new Category()
      {
        Id = Category.Id,
        Name = Category.Name,
      };
      _context.Entry(newCategory).State = EntityState.Added;
      await _context.SaveChangesAsync();
      return newCategory;
    }

    /// <summary>
    /// DELETE Method from SQL Server
    /// </summary>
    /// <param name="id">Id for Category to Delete</param>
    /// <returns></returns>
    public async Task DeleteCategory(int id)
    {
      Category Category = await _context.DBCategories.FindAsync(id);
      _context.Entry(Category).State = EntityState.Deleted;
      await _context.SaveChangesAsync();
    }

    /// <summary>
    /// GET Method for a specific Category
    /// </summary>
    /// <param name="id">Id for Category to Retrieve</param>
    /// <returns>Retrieved Category Object</returns>
    public async Task<CategoryDTO> GetCategory(int id)
    {
      CategoryDTO newCategoryDTO = await _context.DBCategories
                                                 .Where(c => c.Id == id)
                                                 .Select(c => new CategoryDTO
                                                 {
                                                   Id = c.Id,
                                                   Name = c.Name,
                                                 })
                                                 .FirstOrDefaultAsync();
      return newCategoryDTO;
    }

    /// <summary>
    /// GET Method for all Categorys
    /// </summary>
    /// <returns>List of all stored Categorys</returns>
    public async Task<List<CategoryDTO>> GetCategories()
    {
      var Categories = await _context.DBCategories
                                     .Select(p => new CategoryDTO
                                     {
                                       Id = p.Id,
                                       Name = p.Name
                                     })
                                     .ToListAsync();
      return Categories;
    }

    /// <summary>
    /// PUT Method to update a specified Category
    /// </summary>
    /// <param name="id">Id of Category to Update</param>
    /// <param name="Category">Updated Category Information</param>
    /// <returns>Updated Object</returns>
    public async Task<Category> UpdateCategory(int id, CategoryDTO Category)
    {
      Category newCategory = new Category()
      {
        Id = Category.Id,
        Name = Category.Name
      };
      _context.Entry(newCategory).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return newCategory;
    }

    /// <summary>
    /// POST Method for adding category and product relationships from join table
    /// </summary>
    /// <param name="categoryId">id of category to add</param>
    /// <param name="productId">id of product to add</param>
    /// <returns></returns>
    public async Task AddProduct(int categoryId, int productId)
    {
      CategoryProducts newCategoryProducts = new CategoryProducts
      {
        CategoryId = categoryId,
        ProductId = productId
      };

      _context.Entry(newCategoryProducts).State = EntityState.Added;
      await _context.SaveChangesAsync();
    }

    /// <summary>
    /// DELETE Method for removing category and product relationships from join table
    /// </summary>
    /// <param name="categoryId">id of category to add</param>
    /// <param name="productId">id of product to add</param>
    /// <returns></returns>
    public async Task RemoveProduct(int categoryId, int productId)
    {
      var result = await _context.DBCategoryProducts.FirstOrDefaultAsync(cp =>
                                                                       cp.CategoryId == categoryId && cp.ProductId == productId);
      _context.Entry(result).State = EntityState.Deleted;
      await _context.SaveChangesAsync();
    }

  }
}
