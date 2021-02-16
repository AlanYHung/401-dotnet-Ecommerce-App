using System.Collections.Generic;

namespace Ecommerce_App.Models.API
{
  public class CategoryDTO
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public List<CategoryProducts> CategoryProductsList { get; set; }

  }
}
