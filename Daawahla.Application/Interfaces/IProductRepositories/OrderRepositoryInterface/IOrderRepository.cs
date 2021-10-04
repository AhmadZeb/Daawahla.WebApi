using Daawahla.Application.Interfaces.IGenericRepositories;
using Daawahla.Core.Entities.OrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Application.Interfaces.IProductRepositories.OrderRepositoryInterface
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
    }
}
