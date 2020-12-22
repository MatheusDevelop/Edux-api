using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Entities
{
    public class Base
    {
        public Guid id { get; set; }
        public Base()
        {
            id = Guid.NewGuid();
        }
    }
}
