using Ecommerce_App.Data;
using Ecommerce_App.Models.API;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Models.Interfaces.Services
{
  public class ProductRepository : IProduct
  {
    private ECommerceDbContext _context;

    /// <summary>
    /// Constructor connects to sql database
    /// </summary>
    /// <param name="context">sql database</param>
    public ProductRepository(ECommerceDbContext context)
    {
      _context = context;
    }

    /// <summary>
    /// POST Method to SQL Server
    /// </summary>
    /// <param name="Product">Product Object to Add into Sql Table</param>
    /// <returns></returns>
    public async Task<Product> CreateProduct(ProductDTO Product)
    {
      Product newProduct = new Product()
      {
        Id = Product.Id,
        Name = Product.Name,
        Price = Product.Price
      };
      _context.Entry(newProduct).State = EntityState.Added;
      await _context.SaveChangesAsync();
      return newProduct;
    }

    /// <summary>
    /// DELETE Method from SQL Server
    /// </summary>
    /// <param name="id">Id for Product to Delete</param>
    /// <returns></returns>
    public async Task DeleteProduct(int id)
    {
      Product Product = await _context.DBProducts.FindAsync(id);
      _context.Entry(Product).State = EntityState.Deleted;
      await _context.SaveChangesAsync();
    }

    /// <summary>
    /// GET Method for a specific Product
    /// </summary>
    /// <param name="id">Id for Product to Retrieve</param>
    /// <returns>Retrieved Product Object</returns>
    public async Task<ProductDTO> GetProduct(int id)
    {
      ProductDTO newProductDTO = await _context.DBProducts
                                               .Where(p => p.Id == id)
                                               .Select(p => new ProductDTO
                                               {
                                                 Id = p.Id,
                                                 Name = p.Name,
                                                 Price = p.Price
                                               })
                                               .FirstOrDefaultAsync();
      return newProductDTO;
    }

    /// <summary>
    /// GET Method for all Products
    /// </summary>
    /// <returns>List of all stored products</returns>
    public async Task<List<ProductDTO>> GetProducts()
    {
      var Products = await _context.DBProducts
                                   .Select(p => new ProductDTO
                                   {
                                      Id = p.Id,
                                      Name = p.Name,
                                      Price = p.Price
                                   })
                                   .ToListAsync();
      return Products;
    }

    /// <summary>
    /// PUT Method to update a specified Product
    /// </summary>
    /// <param name="id">Id of product to Update</param>
    /// <param name="Product">Updated Product Information</param>
    /// <returns>Updated Object</returns>
    public async Task<Product> UpdateProduct(int id, ProductDTO Product)
    {
      Product newProduct = new Product()
      {
        Id = Product.Id,
        Name = Product.Name,
        Price = Product.Price
      };
      _context.Entry(newProduct).State = EntityState.Modified;
      await _context.SaveChangesAsync();
      return newProduct;
    }
  }
}
