using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OnlineShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopApi.Controllers
{
    [ApiController]
    [Route("api/Autentication")]
    public class AutenticationController : ControllerBase
    {

        ICustomerData customerdata;
        public AutenticationController(ICustomerData _customerData)
        {
            customerdata = _customerData;
        }
        [HttpPost]
        public IActionResult LoginService([FromBody]Autentication autentication )
        {
            Customer customer = customerdata.GetCustomerByNameAndPassword(autentication.username, autentication.password);

            if (customer == null)
            {
                return NotFound("Autentication failed");
            }
                return Ok(customer); 
        }
    }
}
