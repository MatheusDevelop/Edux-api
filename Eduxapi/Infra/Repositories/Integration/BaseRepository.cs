using Eduxapi.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Infra.Repositories.Integration
{
    public class BaseRepository
    {
        public Eduxcontext con = new Eduxcontext();
    }
}
