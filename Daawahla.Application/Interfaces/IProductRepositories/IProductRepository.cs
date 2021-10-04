using Daawahla.Application.Interfaces.IGenericRepositories;
using Daawahla.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Application.Interfaces.IProductRepositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}
