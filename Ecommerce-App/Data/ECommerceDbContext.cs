using Ecommerce_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Ecommerce_App.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;

namespace Ecommerce_App.Data
{
  public class ECommerceDbContext : IdentityDbContext<AuthUser>
  {
    public DbSet<Category> DBCategories { get; set; }
    public DbSet<CategoryProducts> DBCategoryProducts { get; set; }
    public DbSet<Product> DBProducts { get; set; }

    public ECommerceDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<CategoryProducts>().HasKey(
                categoryProducts => new { categoryProducts.CategoryId, categoryProducts.ProductId });

      SeedRole(modelBuilder, "Administrator", "read", "create", "update", "delete");
      SeedRole(modelBuilder, "Editor", "read", "create", "update");
      SeedRole(modelBuilder, "Writer", "read", "create");

      //---------Category Seeds
      modelBuilder.Entity<Category>().HasData(new Category
      {
        Id = 1,
        Name = "Zoas"
      });

      modelBuilder.Entity<Category>().HasData(new Category
      {
        Id = 2,
        Name = "Polyps"
      });

      modelBuilder.Entity<Category>().HasData(new Category
      {
        Id = 3,
        Name = "Montiporas"
      });

      //------------ Product Seeds
      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = 1,
        Name = "Red Bull Zoanthids",
        Price = 40
      });

      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = 2,
        Name = "WarLock Zoanthids",
        Price = 80
      });

      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = 3,
        Name = "SuperStar Zoanthids",
        Price = 180
      });

      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = 4,
        Name = "Gold Schalagger Polyps",
        Price = 40
      });

      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = 5,
        Name = "Marsian Man Polyps",
        Price = 20
      });

      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = 6,
        Name = "Utter Chaos Polyps",
        Price = 20
      });

      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = 7,
        Name = "Sunset Montipora",
        Price = 75
      });

      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = 8,
        Name = "Northern Light Montipora",
        Price = 40
      });

      modelBuilder.Entity<Product>().HasData(new Product
      {
        Id = 9,
        Name = "Jason fox Brain Freeze",
        Price = 200
      });

      //------- CategoryProduct seeds
      modelBuilder.Entity<CategoryProducts>().HasData(new CategoryProducts
      {
        CategoryId = 1,
        ProductId = 1
      });

      modelBuilder.Entity<CategoryProducts>().HasData(new CategoryProducts
      {
        CategoryId = 1,
        ProductId = 2
      });

      modelBuilder.Entity<CategoryProducts>().HasData(new CategoryProducts
      {
        CategoryId = 1,
        ProductId = 3
      });

      //----------
      modelBuilder.Entity<CategoryProducts>().HasData(new CategoryProducts
      {
        CategoryId = 2,
        ProductId = 4
      });

      modelBuilder.Entity<CategoryProducts>().HasData(new CategoryProducts
      {
        CategoryId = 2,
        ProductId = 5
      });

      modelBuilder.Entity<CategoryProducts>().HasData(new CategoryProducts
      {
        CategoryId = 2,
        ProductId = 6
      });

      //----------
      modelBuilder.Entity<CategoryProducts>().HasData(new CategoryProducts
      {
        CategoryId = 3,
        ProductId = 7
      });

      modelBuilder.Entity<CategoryProducts>().HasData(new CategoryProducts
      {
        CategoryId = 3,
        ProductId = 8
      });

      modelBuilder.Entity<CategoryProducts>().HasData(new CategoryProducts
      {
        CategoryId = 3,
        ProductId = 9
      });
    }

    private int nextId = 1; // we need this to generate a unique id on our own
    private void SeedRole(ModelBuilder modelBuilder, string roleName, params string[] permissions)
    {
      var role = new IdentityRole
      {
        Id = roleName.ToLower(),
        Name = roleName,
        NormalizedName = roleName.ToUpper(),
        ConcurrencyStamp = Guid.Empty.ToString()
      };

      modelBuilder.Entity<IdentityRole>().HasData(role);

      // Go through the permissions list (the params) and seed a new entry for each
      var roleClaims = permissions.Select(permission =>
      new IdentityRoleClaim<string>
      {
        Id = nextId++,
        RoleId = role.Id,
        ClaimType = "permissions", // This matches what we did in Startup.cs
        ClaimValue = permission
      }).ToArray();

      modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(roleClaims);
    }
  } // end of class
} // end of namespace