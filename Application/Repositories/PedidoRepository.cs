using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories
{
    public class PedidoRepository : GenericRepository<Pedido>, IPedido
    {
        public PedidoRepository(contextNike context) : base(context)
        {
        }
    }
}