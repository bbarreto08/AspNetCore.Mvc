using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Site.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public Pedido(Guid id)
        {
            Id = Guid.NewGuid();
        }

    }
}
