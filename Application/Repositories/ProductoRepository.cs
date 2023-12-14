using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class ProductoRepository : GenericRepository<Producto>, IProducto
    {
        public ProductoRepository(contextNike context) : base(context)
        {
        }
    }
}