using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        //Bir ürünün bir kategorisi olabilir fakat bir kategorinin birden fazla ürünü olabilir.
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
    }
}
