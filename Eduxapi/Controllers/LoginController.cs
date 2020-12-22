using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduxapi.Domain.Entities;
using Eduxapi.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Eduxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration config;
        public readonly LoginService service;
        public LoginController(IConfiguration _config)
        {
            config = _config;
            service = new LoginService(config);

        }
        [HttpPost]
        public ActionResult login(Usuario user)
        {
            var res = service.Login(user);
            if (res.GetType() == typeof(Boolean)) return BadRequest();
            return Ok( new {token = res});
        }
    }
}
