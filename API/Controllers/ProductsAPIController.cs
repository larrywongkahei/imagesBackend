using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsAPIController : ControllerBase
    {
        // GET: values
        [HttpGet]
        public string Get()
        {
            Product product = new Product();
            return product.getAll();
        }

        // GET values/5
        [HttpGet("{id}")]
        public string? Get(int id)
        {
            Product product = new Product();
            return product?.getNumbersOfProduct(id);
        }
    }
}
