using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ICiudad _ciudades;
        private ICliente _clientes;
        private IDepartamento _departamentos;
        private IDireccion _direcciones;
        private IFormaPago _formaPagos;
        private IOrden _ordenes; // 2611
        private IPago _pagos;
        private IPais _paises;
        private IPedido _pedidos;
        private IProducto _productos;
        private IRol _rols;
        private ITipoProducto _tipoProductos;
        private IUser _users;

        private readonly contextNike _context;

        public UnitOfWork(contextNike context)
        {
            _context = context;
        }

        public ICiudad Ciudades // 2611
        {
            get
            {
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _ciudades;
            }
        }

        public ICliente Clientes // 2611
        {
            get
            {
                if (_clientes == null)
                {
                    _clientes = new ClienteRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _clientes;
            }
        }

        public IDepartamento Departamentos // 2611
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _departamentos;
            }
        }

        public IDireccion Direcciones // 2611
        {
            get
            {
                if (_direcciones == null)
                {
                    _direcciones = new DireccionRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _direcciones;
            }
        }

        public IFormaPago FormaPagos // 2611
        {
            get
            {
                if (_formaPagos == null)
                {
                    _formaPagos = new FormaPagoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _formaPagos;
            }
        }

        public IOrden Ordenes // 2611
        {
            get
            {
                if (_ordenes == null)
                {
                    _ordenes = new OrdenRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _ordenes;
            }
        }

        public IPago Pagos // 2611
        {
            get
            {
                if (_pagos == null)
                {
                    _pagos = new PagoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _pagos;
            }
        }

        public IPais Paises // 2611
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _paises;
            }
        }

        public IPedido Pedidos // 2611
        {
            get
            {
                if (_pedidos == null)
                {
                    _pedidos = new PedidoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _pedidos;
            }
        }

        public IProducto Productos // 2611
        {
            get
            {
                if (_productos == null)
                {
                    _productos = new ProductoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _productos;
            }
        }

        public IRol Rols // 2611
        {
            get
            {
                if (_rols == null)
                {
                    _rols = new RolRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _rols;
            }
        }

        public ITipoProducto TipoProducto // 2611
        {
            get
            {
                if (_tipoProductos == null)
                {
                    _tipoProductos = new TipoProductoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _tipoProductos;
            }
        }

        public IUser Users // 2611
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _users;
            }
        }

        public ITipoProducto TipoProductos => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync() // 2611
        {
            return _context.SaveChangesAsync();
        }
    }
}