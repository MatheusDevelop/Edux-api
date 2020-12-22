using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduxapi.Domain.Entities;
using Eduxapi.Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eduxapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurtidaController : ControllerBase
    {
        Eduxcontext con = new Eduxcontext();
        [HttpPost]
        public void Curtir(Curtida curtida)
        {
            var curtidaSearch = con.curtidas.FirstOrDefault(e => e.usuarioid == curtida.usuarioid && e.postid == curtida.postid);
            if (curtidaSearch != null)
            {
                con.curtidas.Remove(curtidaSearch);
                con.SaveChanges();
            }
            else
            {
                var newC = new Curtida();
                newC.postid = curtida.postid;
                newC.usuarioid = curtida.usuarioid;
                con.curtidas.Add(newC);
                con.SaveChanges();
            }
        }
    }
}
