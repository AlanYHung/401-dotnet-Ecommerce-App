using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Models
{
  public class CategoryProducts
  {
    public int CategoryId { get; set; }
    public int ProductId { get; set; }

    public List<Category> CategoryList { get; set; }
    public List<Product> ProductList { get; set; }
  }
}
