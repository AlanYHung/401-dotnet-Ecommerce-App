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
        public ProductRepository(ECommerceDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Create(ProductDTO Product)
        {
            Product newProduct = new Product()
            {
                Id = Product.Id,
                Name = Product.Name,
                ProductLayout = Product.ProductLayout
            };
            _context.Entry(newProduct).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return newProduct;
        }
        public async Task DeleteProduct(int id)
        {
            Product Product = await _context.Products.FindAsync(id);
            _context.Entry(Product).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
        public async Task<ProductDTO> GetProduct(int id)
        {
            ProductDTO newProductDTO = await _context.Products
                                               .Where(r => r.Id == id)
                                               .Select(r => new ProductDTO
                                               {
                                                   Id = r.Id,
                                                   Name = r.Name,
                                                   ProductLayout = r.ProductLayout,
                                                   Amenities = r.ProductAmenities
                                                              .Select(ra => new AmenitiesDTO
                                                              {
                                                                  Id = ra.Amenity.Id,
                                                                  Name = ra.Amenity.Name
                                                              })
                                                              .ToList()
                                               })
                                               .FirstOrDefaultAsync();
            return newProductDTO;
        }
        public async Task<List<ProductDTO>> GetProducts()
        {
            var Products = await _context.Products
                                      .Select(r => new ProductDTO
                                      {
                                          Id = r.Id,
                                          Name = r.Name,
                                          ProductLayout = r.ProductLayout,
                                          Amenities = r.ProductAmenities
                                                     .Select(ra => new AmenitiesDTO
                                                     {
                                                         Id = ra.Amenity.Id,
                                                         Name = ra.Amenity.Name
                                                     })
                                                     .ToList()
                                      })
                                      .ToListAsync();
            return Products;
        }
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
