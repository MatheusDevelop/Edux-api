using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduxapi.Domain.Entities;
using Eduxapi.Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eduxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        Eduxcontext con = new Eduxcontext();
        [HttpPost]
        public ActionResult Post(Post post)
        {
            con.posts.Add(post);
            con.SaveChanges();
            return Ok();
        }
        [HttpGet]
        public ActionResult<List<Post>> get()
        {
            return con.posts.Include(e=>e.usuario).Include(e => e.curtidas).ToList();
        }
    }
}
