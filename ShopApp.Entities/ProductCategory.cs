using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
    //Kategori ve Ürünler arasında çoka çok ilişki kurabilmek için bu alanı oluşturduk. 
    // Örneğin bir telefon hem Samsung kategorisine ait olurken aynı zamanda elektronik kategorisinide ait olabilir.
    public class ProductCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
