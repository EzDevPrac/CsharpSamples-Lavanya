using Microsoft.AspNetCore.Mvc;
using OnlineShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopApi.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        IProductData productData;
        public ProductController(IProductData _productData)
        {
            productData = _productData;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            var list = productData.GetList();
            if (list.Count == 0)
            {
                return NotFound("no items");
            }
            else
            {
                return Ok(list);
            }
        }
        [HttpGet("{name}", Name = "GetProduct")]
        public IActionResult Get(string name)
        {
            var product = productData.GetProductByName(name);
            if (product == null)
            {
                return NotFound("No customer found with the given name");
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProducts([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            productData.AddItem(product);
            return Ok();
        }

    }
}
