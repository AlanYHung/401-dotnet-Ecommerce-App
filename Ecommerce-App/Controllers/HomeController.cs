using Ecommerce_App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      List<Category> categoryList = new List<Category>()
      {
        new Category() { Id = 1, Name = "Zoas" },
        new Category() { Id = 2, Name = "Polyps" },
        new Category() { Id = 3, Name = "Montiporas" }
      };
      
      return View(categoryList);
    }

    public IActionResult CategoryDetails(int id, string name)
    {
      Category catObj = new Category()
      {
        Id = id,
        Name = name,
        CategoryProductsList = new List<CategoryProducts>()
        {
          new CategoryProducts
          {
            CategoryId = id, ProductId = 1, ProductList = new List<Product>
                                            {
                                              new Product() { Id = 1, Name = "Test1", Price = 9.99M },
                                              new Product() { Id = 2, Name = "Test2", Price = 99.99M },
                                              new Product() { Id = 3, Name = "Test3", Price = 999.99M }
                                            }
          }
        }
      };

      return View(catObj);
    }

    public IActionResult ProductDetails(int id, string name, decimal price)
    {
      Product newProduct = new Product()
      {
        Id = id,
        Name = name,
        Price = price
      };

      return View(newProduct);
    }
  } // end of class
} // end of namespace
