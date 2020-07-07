using OnlineShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace OnlineShopApi
{
    public class CustomerData : ICustomerData
    {
      public static List<Customer> customers = new List<Customer>()
        {
            new Customer(){Name ="Lavanya",Email="Lavanya@gmail.com",Phonenumber="7412589632",Password="asd"},
            new Customer(){Name ="Tereena",Email="Tereena@gmail.com",Phonenumber="8527419510",Password="qwe"},
            new Customer(){Name ="Srini",Email="Srini@gmail.com",Phonenumber="8523479618",Password="asx"}
        };
        public List<Customer> GetList()
        {
            if (customers.Count == 0)
            {
                return null;
            }
                return customers;
            
        }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public Customer GetCustomerByName(string name)
        {
            Customer customer;
             customer = customers.SingleOrDefault(x => x.Name == name);
            return customer;
        }
        public bool DeleteCustomer(string name)
        {
            bool value = false;
            for(int i=0;i<customers.Count;i++)
            {
                if(customers[i].Name == name)
                {
                    customers.Remove(customers[i]);
                    value = true;
                }
            }
            return value;
        }
        public Customer GetCustomerByNameAndPassword(string name, string password)
        {
            Customer customer = null;
            for(int i=0;i<customers.Count;i++)
            {
                if(customers[i].Name == name && customers[i].Password == password)
                {
                    customer = customers[i];
                }
            }
            return customer;
        }
    }
}
