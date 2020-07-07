using OnlineShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopApi
{
   public interface IProductData
   {
        void AddItem(Product product);
        List<Product> GetList();
        Product GetProductByName(string name);
   }
}
