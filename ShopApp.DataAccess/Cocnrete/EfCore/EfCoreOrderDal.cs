using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Cocnrete.EfCore
{
    public class EfCoreOrderDal : EfCoreGenericRepository<Order,ShopContext>,IOrderDal
    {
    }
}
