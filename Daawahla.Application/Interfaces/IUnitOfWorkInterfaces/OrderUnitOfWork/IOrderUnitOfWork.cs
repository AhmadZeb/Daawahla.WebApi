using Daawahla.Application.Interfaces.IProductRepositories.OrderRepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Application.Interfaces.IUnitOfWorkInterfaces.OrderUnitOfWork
{
    public interface IOrderUnitOfWork
    {
        IOrderRepository Orders { get; }
    }
}
