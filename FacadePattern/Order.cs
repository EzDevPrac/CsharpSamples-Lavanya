using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
        public class Order
        {
            public void PlaceOrder()
            {
                Console.WriteLine("Place Order Started");
                Product product = new Product();
               string process1 = product.GetProductDetails();
                 Console.WriteLine(process1);
                Payment payment = new Payment();
               string process2 = payment.MakePayment();
                 Console.WriteLine(process2);
                Invoice invoice = new Invoice();
               string process3 = invoice.Sendinvoice();
                Console.WriteLine(process3);
                Console.WriteLine("Order Placed Successfully");
            }
        }
    }
