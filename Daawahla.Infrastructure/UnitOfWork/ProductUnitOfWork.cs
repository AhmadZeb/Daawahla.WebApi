using Daawahla.Application.Interfaces;
using Daawahla.Application.Interfaces.IProductRepositories;
using Daawahla.Application.Interfaces.IUnitOfWorkInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Infrastructure.UnitOfWork
{
    public class ProductUnitOfWork : IUnitOfWork
    {
        public ProductUnitOfWork(IProductRepository productRepository)
        {
            Products = productRepository;
        }
        public IProductRepository Products { get; }
    }
}
