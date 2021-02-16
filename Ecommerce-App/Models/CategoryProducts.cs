using System.Collections.Generic;

namespace Ecommerce_App.Models
{
  public class CategoryProducts
  {
    public int CategoryId { get; set; }
    public int ProductId { get; set; }

    public Category Category { get; set; }
    public Product Product { get; set; }
  }
}
