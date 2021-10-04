using Daawahla.Application.Interfaces.IProductRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Application.Interfaces.IUnitOfWorkInterfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}
