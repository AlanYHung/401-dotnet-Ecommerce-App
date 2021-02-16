using System.Collections.Generic;

namespace Ecommerce_App.Models
{
  public class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public List<CategoryProducts> CategoryProductList { get; set; }
  }
}
