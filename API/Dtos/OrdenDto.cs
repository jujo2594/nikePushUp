using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class OrdenDto
    {
        public int Id { get; set; }
        public int? Cantidad { get; set; }

        public int? IdProductoFk { get; set; }
    }
}