using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        //Bir ürünün bir kategorisi olabilir fakat bir kategorinin birden fazla ürünü olabilir.
        //public List<Product> Products { get; set; }
    }
}
