using OnlineShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopApi
{
    public class ProductData: IProductData
    {
        static List<Product> list = new List<Product>
        {
             new Product() { Name = "Mi note Pro", id = 1, Price = 20000 },
             new Product() { Name = "Laptop", id = 2, Price = 50000 } 
        };
         public void AddItem(Product product)
         {
            list.Add( product);    
         }
        public List<Product> GetList()
        {
            return list;
        }
        public Product GetProductByName(string name)
        {
            Product product;
            product = list.SingleOrDefault(x => x.Name == name);
            return product;
        }

    }
}
