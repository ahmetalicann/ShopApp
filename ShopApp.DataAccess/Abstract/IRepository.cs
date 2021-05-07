using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
    //Burda Generic bir tip olustuduk ve bu sayede her tablo için ef hazırlamak yerıne burda generic oalrak belirtiriz ve gerekli yerlere gidip
    //implemente ederiz. T yerıne <Product> yazdıgımızda artık Product için çalışır.
    public interface IRepository<T>
    {
        //Kullanıcı bir id isteği yolladığı zaman Product tablosundan bunu bulup geri döndürücez.
        T GetById(int id);
        //Kullanıcı linq ile istediği 1 kaydı geri döndürür.
        T GetOne(Expression<Func<T, bool>> filter);
        //Kullanıcı linq ile istediği kayıtları geri döndürür.
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
