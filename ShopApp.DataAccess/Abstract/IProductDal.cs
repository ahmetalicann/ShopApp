using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
    //Bu implementasyon ile IRepository içerisindeki bütün methodları kullanırız. Fakat buraya özel bir methodf yazmak ıstersekte bu bolume yazarız.

    public interface IProductDal : IRepository<Product>
    {
        IEnumerable<Product> GetPopularProduct();
    }
}
