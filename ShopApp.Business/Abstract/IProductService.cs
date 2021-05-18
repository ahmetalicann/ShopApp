using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        //Id ye göre ürün getirecek.
        Product GetById(int id);
        Product GetProductDetails(int id);
        //Bütün Productları getirecek method
        List<Product> GetAll();
        //istediğimiz methodu buraya ekleyip içini doldurmamız gerekir.
        List<Product> GetProductsByCategory(string category,int page, int pageSize);

        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        int GetCountByCategory(string category);
    }
}
