using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Models.API
{
  public class ProductDTO
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public List<CategoryProducts> CategoryProductList { get; set; }

  }
}
