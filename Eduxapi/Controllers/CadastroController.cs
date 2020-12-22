using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduxapi.Domain.Entities;
using Eduxapi.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eduxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        SignUp service = new SignUp();
        [HttpPost]
        public ActionResult cadastro(Usuario user)
        {
            var res = service.Cadastro(user);
            if (!res) return BadRequest();
            return Ok();            
        }
    }
}
