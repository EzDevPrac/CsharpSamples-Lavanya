using Microsoft.AspNetCore.Mvc;
using Moq;
using Newtonsoft.Json.Linq;
using OnlineShopApi.Controllers;
using OnlineShopApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OnlineShopApi.Test
{
    public class AutenticationControllerTest
    {
        private readonly Mock<ICustomerData> mockcustomerdata;
        private readonly AutenticationController _controller;
        public AutenticationControllerTest()
        {
            mockcustomerdata = new Mock<ICustomerData>();
            _controller = new AutenticationController(mockcustomerdata.Object);
        }
        [Theory]
        [InlineData("Lavanya","asx")]
        [InlineData("sai","asd")]
        [InlineData("lavanya","asd")]
        public void Task_Login_Returns_NotFoundStatusCode_IfTheCredentails_AreNotCorrect(string name, string pass)
        {
        
            Autentication autentication = new Autentication { username = name, password = pass };
            //Act  
            var data = _controller.LoginService(autentication);
            //Assert  
            Assert.IsType<NotFoundObjectResult>(data);
        }
        [Theory]
        [InlineData("Lavanya","asd")]
        [InlineData("Srini","asx")]
        public void Task_Login_Returns_OkSatutsCode_WithCustomerDetails_IftheCredentails_AreCorrect(string name, string pass)
        { 
            Autentication autentication = new Autentication { username = name, password = pass };
            //Act  
            var data = _controller.LoginService(autentication);
            //Assert  
            Assert.IsType<OkObjectResult>(data);
        }
    }
}
