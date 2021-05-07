using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Cocnrete.EfCore
{
    //Bu classta kullandıgımız tabloalrı DbSet ettik ve override onfigure ile sql server connectionımızı olusturduk. bunları yaparken DbContext ten faydalandık.
    public class ShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-E087HU5;Database=ShopDb;integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
