using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OnlineShopApi.Models;

namespace OnlineShopApi.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class CustomerController : ControllerBase
    {
        ICustomerData customers; 
       public CustomerController(ICustomerData customerData)
       {
            customers = customerData;
       }

        [HttpGet]
        public IActionResult Gets()
        {
            if(customers.GetList()== null)
            {
                return BadRequest();
            }
            return Ok(this.customers.GetList());
            
        }
        [HttpGet("{name}" ,Name = "GetCustomer" )]
        public IActionResult Get(string name)
        {
            var customer = customers.GetCustomerByName(name);
            if (customer == null)
            {
                return NotFound("No customer found with the given name");
            }
                return Ok(customer); 
        }
        [HttpPost]
        public IActionResult Register([FromBody] Customer customerobject)
        {
            var list = customers.GetList();
            if (customerobject == null)
            {
                return BadRequest();
            }
            customers.AddCustomer(customerobject);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(string name)
        {
            var status = customers.DeleteCustomer(name);
            if (status)
            {
                return Ok();
            }
            else
            {
                return NotFound("Sorry no such customer found");
            } 
        }
    }
}
