using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MyFirstApi.Controllers
{   [ApiController]
    [Route("api/country")]
    public class CountryController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {

            ServiceFile service = new ServiceFile();
            var countries = service.GetFileData();
            return Ok(countries);
        }
        [HttpGet("{name}")]
        public IActionResult GetCountry(string name)
        {
            ServiceFile service = new ServiceFile();
            var result = service.GetFileData();
            var cities = result.countries.FirstOrDefault(c => c.Country == name);
                 if(cities == null)
                 {
                return NotFound();
                 }
            return Ok(cities);
        }
    }


}

