using Daawahla.Application.Interfaces.IProductRepositories.OrderRepositoryInterface;
using Daawahla.Application.Interfaces.IUnitOfWorkInterfaces.OrderUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Infrastructure.UnitOfWork.OrderUnitOfWork
{
    public class OrderUnitOfWork : IOrderUnitOfWork
    {
        public OrderUnitOfWork(IOrderRepository orderRepository)
        {
            Orders = orderRepository;
        }
        public IOrderRepository Orders { get; }
    }
}
