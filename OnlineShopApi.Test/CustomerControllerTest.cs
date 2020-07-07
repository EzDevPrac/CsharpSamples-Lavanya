using Microsoft.AspNetCore.Mvc;
using Moq;
using OnlineShopApi.Controllers;
using OnlineShopApi.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace OnlineShopApi.Test
{
    public class CustomerControllerTest
    {
        private readonly Mock<ICustomerData> mockcustomerdata;
        private readonly CustomerController _controller;
        public CustomerControllerTest()
        {
            mockcustomerdata = new Mock<ICustomerData>();
            _controller = new CustomerController(mockcustomerdata.Object);
        }
        [Fact]
        public void GetCustomer_itshould_return_customersWithOkayStatusCode()
        {
            //Act  
             mockcustomerdata.Setup(x => x.GetList()).Returns(new List<Customer>());
            var data = _controller.Gets();
            //Assert 
            Assert.IsType<OkObjectResult>(data);
        }


        [Theory]
        [InlineData("Lavanya")]
        [InlineData("Tereena")]
        [InlineData("Srini")]
        public void Task_GetCustomerByName_Returns_CustomerDetailsWithOkayStatusCode(string name)
        {
            //Act  
             mockcustomerdata.Setup(x => x.GetCustomerByName(name)).Returns(new Customer());
            //Assert  
            var data = _controller.Get(name);
            Assert.IsType<OkObjectResult>(data);
        }
        [Theory]
        [InlineData("sai")]
        [InlineData("shashank")]
        public void Task_GetCustomerByName_Returns_NotFoundStatusCode(string name)
        {
            mockcustomerdata.Setup(x => x.GetCustomerByName(name)).Returns(new Customer());
            //Act  
            var data = _controller.Get(name);
            //Assert  
            Assert.IsType<NotFoundObjectResult>(data);

        }
        [Fact]
        public void Task_Register_Returns_OkaystatusCode()
        {
            mockcustomerdata.Setup(x => x.AddCustomer(new Customer()));
            //Act  
            Customer customer = new Customer() { Name = "sai", Email = "sai@gmail.com", Phonenumber = "852963", Password = "asd" };
            var data = _controller.Register(customer);
            //Assert  
            Assert.IsType<OkResult>(data);
        }
        [Fact]
        public void Task_Register_Returns_BadStatusCodeIfThe_ObjectIsNull()
        {
            mockcustomerdata.Setup(x => x.AddCustomer(new Customer()));
            //Act  
            var data = _controller.Register(null);
            //Assert  
            Assert.IsType<BadRequestResult>(data);
        }
        [Theory]
        [InlineData("Lavanya")]
        public void Task_DeleteCustomer_Returns_OkStatusCode_IfTheCustomerFound(string name)
        {
            mockcustomerdata.Setup(x => x.DeleteCustomer(name)).Returns(true);
            var data = _controller.Delete(name);
            Assert.IsType<OkResult>(data);
        }

        [Theory]
        [InlineData("sai")]
        [InlineData("karan")]
        public void Task_DeleteCustomer_Returns_NotFoundStatusCode_IfTheCustomerNotFound(string name)
        {
            mockcustomerdata.Setup(x => x.DeleteCustomer(name)).Returns(true);
            var data = _controller.Delete(name);
            Assert.IsType<NotFoundResult>(data);
        }
    }
}
