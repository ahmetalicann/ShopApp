using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class CategoryListViewModel
    {
        //Seçilen kategoriyi active etmek için eklediğimiz model
        public string SelectedCategory { get; set; }
        public List<Category> Categories { get; set; }
    }
}
