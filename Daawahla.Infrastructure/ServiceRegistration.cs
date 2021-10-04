using Daawahla.Application.Interfaces;
using Daawahla.Application.Interfaces.IMailService;
using Daawahla.Application.Interfaces.IProductRepositories;
using Daawahla.Application.Interfaces.IProductRepositories.OrderRepositoryInterface;
using Daawahla.Application.Interfaces.IUnitOfWorkInterfaces;
using Daawahla.Application.Interfaces.IUnitOfWorkInterfaces.OrderUnitOfWork;
using Daawahla.Application.Interfaces.JWTAuthManager;
using Daawahla.Infrastructure.Repositories;
using Daawahla.Infrastructure.Repositories.JWTAuthManager;
using Daawahla.Infrastructure.Repositories.MailServiceRepository;
using Daawahla.Infrastructure.Repositories.OrderRepository;
using Daawahla.Infrastructure.UnitOfWork;
using Daawahla.Infrastructure.UnitOfWork.OrderUnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
          
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderUnitOfWork, OrderUnitOfWork>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IMailRepository, MailRepository>();


            services.AddTransient<IUnitOfWork, ProductUnitOfWork>();
            services.AddSingleton<IJWTAuthManager, JWTAuthManagerRepository>();
        }
    }
}
