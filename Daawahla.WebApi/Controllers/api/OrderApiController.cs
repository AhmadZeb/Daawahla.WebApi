using Daawahla.Application.Interfaces.IUnitOfWorkInterfaces.OrderUnitOfWork;
using Daawahla.Core.Entities.OrderModel;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daawahla.WebApi.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderApiController : ControllerBase
    {
        
        private readonly IOrderUnitOfWork _orderUnitOfWork;

        public OrderApiController(IOrderUnitOfWork orderUnitOfWork)
        {
            this._orderUnitOfWork = orderUnitOfWork;
        }
        private static readonly ILog log = LogManager.GetLogger(typeof(OrderApiController));
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _orderUnitOfWork.Orders.GetAllAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                log4net.GlobalContext.Properties["username"] = "Ahmad Zeb";
                log.Info(ex.Message);                
                throw;
            }
           
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var data = await _orderUnitOfWork.Orders.GetByIdAsync(id);
                if (data == null) return Ok();
                return Ok(data);
            }
            catch (Exception ex)
            {
                log4net.GlobalContext.Properties["username"] = "Ahmad Zeb";
                log.Info(ex.Message);
                throw;
            }
          
        }
        [HttpPost]
        public async Task<IActionResult> Add(Order order)
        {
            try
            {
                var data = await _orderUnitOfWork.Orders.AddAsync(order);
                return Ok(data);
            }
            catch (Exception ex)
            {
                log4net.GlobalContext.Properties["username"] = "Ahmad Zeb";
                log.Info(ex.Message);
                throw;
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var data = await _orderUnitOfWork.Orders.DeleteAsync(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                log4net.GlobalContext.Properties["username"] = "Ahmad Zeb";
                log.Info(ex.Message);
                throw;
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(Order order)
        {
            try
            {
                var data = await _orderUnitOfWork.Orders.UpdateAsync(order);
                return Ok(data);
            }
            catch (Exception ex)
            {
                log4net.GlobalContext.Properties["username"] = "Ahmad Zeb";
                log.Info(ex.Message);
                throw;
            }            
        }
    }
}
