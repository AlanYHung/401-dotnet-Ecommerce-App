﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_App.Models
{
  public class Category
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public List<CategoryProducts> CategoryProductsList { get; set; }
  }
}
