using Ecommerce_App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index(/*string zip*/)
    {
      /*if(zip != null)
      {
        CookieOptions cookieOptions = new CookieOptions(); 
        cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7)); // Sets Cookie to expire in a week
        HttpContext.Response.Cookies.Append("zipCode", zip, cookieOptions); // Adds a cookie to user
      }*/

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
/*      Category catObj = new Category()
      {
        Id = id,
        Name = name,
        CategoryProductsList = new List<CategoryProducts>()
        {
          new CategoryProducts
          {
            CategoryId = id, ProductId = 1, Product = new Product
                                            {
                                              new Product() { Id = 1, Name = "Test1", Price = 9.99M },
                                              new Product() { Id = 2, Name = "Test2", Price = 99.99M },
                                              new Product() { Id = 3, Name = "Test3", Price = 999.99M }
                                            }
          }
        }
      };*/

      return View();
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

    /// <summary>
    /// Class Demo
    /// </summary>
    /// <returns></returns>
    /*public IActionResult Weather()
    {
      string zip = HttpContext.Request.Cookies["zipCode"]; //picks up cookie
      ViewData["zip"] = zip; // sends cookie to display in View
      return View();
    }*/
  } // end of class
} // end of namespace
