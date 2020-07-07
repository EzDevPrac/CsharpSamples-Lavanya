using OnlineShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopApi
{
   public interface ICustomerData
   {
        void AddCustomer(Customer customer);
        Customer GetCustomerByName(string name);
        Customer GetCustomerByNameAndPassword(string name, string password);
        List<Customer> GetList();
        bool DeleteCustomer(string name);
   }
}
