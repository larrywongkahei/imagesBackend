using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/products")]
    public class ProductAPI : Controller
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
    [Route("api/users")]
    public class UserAPI : Controller
    {
        // GET: values
        [HttpGet]
        public string Get()
        {
            User user = new User();
            return user.getAll();
        }

        // GET values/5
        [HttpGet("{id}")]
        public string? Get(int id)
        {
            User user = new User();
            return user?.getNumbersOfUsers(id);
        }
    }
}

