using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersAPIController : ControllerBase
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
