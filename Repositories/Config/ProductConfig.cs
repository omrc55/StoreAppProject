using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductID);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                    new Product { ProductID = 1, CategoryID = 2, ImageUrl = "/images/1.jpg", ProductName = "Computer", Price = 17_000, ShowCase = false },
                    new Product { ProductID = 2, CategoryID = 2, ImageUrl = "/images/2.jpg", ProductName = "Keyboard", Price = 1_000, ShowCase = false },
                    new Product { ProductID = 3, CategoryID = 2, ImageUrl = "/images/3.jpg", ProductName = "Mouse", Price = 500, ShowCase = false },
                    new Product { ProductID = 4, CategoryID = 2, ImageUrl = "/images/4.jpg", ProductName = "Monitor", Price = 7_000, ShowCase = false },
                    new Product { ProductID = 5, CategoryID = 2, ImageUrl = "/images/5.jpg", ProductName = "Deck", Price = 1_500, ShowCase = false },
                    new Product { ProductID = 6, CategoryID = 1, ImageUrl = "/images/6.jpg", ProductName = "History", Price = 25, ShowCase = false },
                    new Product { ProductID = 7, CategoryID = 1, ImageUrl = "/images/7.jpg", ProductName = "Hamlet", Price = 45, ShowCase = false },
                    new Product { ProductID = 8, CategoryID = 3, ImageUrl = "/images/8.jpg", ProductName = "Avatar", Price = 50, ShowCase = true },
                    new Product { ProductID = 9, CategoryID = 3, ImageUrl = "/images/9.jpg", ProductName = "Xp-Pen", Price = 1_500, ShowCase = true },
                    new Product { ProductID = 10, CategoryID = 3, ImageUrl = "/images/10.jpg", ProductName = "Galaxy FE", Price = 7_350, ShowCase = true }
                );
        }
    }
}
