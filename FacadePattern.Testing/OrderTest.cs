using System;
using Xunit;

namespace FacadePattern.Testing
{
    public class OrderTest
    {
        [Fact]
        public void GetProductDetails_ShouldReturn_FetchingtheProductDetails()
        {
            Product product = new Product();
            string str = product.GetProductDetails();
            Assert.Equal("Fetching the Product Details", str);
        }
        [Fact]
        public void MakePayment_ShouldReturn_PaymentDoneSuccessfully()
        {
            Payment payment = new Payment();
            string str = payment.MakePayment();
            Assert.Equal("Payment Done Successfully", str);
        }
        [Fact]
        public void Sendinvoice_ShouldReturn_InvoiceSendSuccessfully()
        {
            Invoice invoice = new Invoice();
            string str = invoice.Sendinvoice();
            Assert.Equal("Invoice Send Successfully", str);

        }

    }
}
