using Daawahla.Application.Interfaces.IProductRepositories.OrderRepositoryInterface;
using Daawahla.Core.Entities.OrderModel;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Infrastructure.Repositories.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
         
         
        private readonly IConfiguration configuration;
        public OrderRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<IReadOnlyList<Order>> GetAllAsync()
        {
            try
            {
                var sql = "spGetAllOrders";
                using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<Order>(sql);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {              
                throw new Exception(ex.Message, ex);                
            }
        }
        public async Task<Order> GetByIdAsync(int id)
        {
            try
            {
                var sql = "SELECT * FROM Orders WHERE Id = @Id";
                using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();
                    var result = await connection.QuerySingleOrDefaultAsync<Order>(sql, new { Id = id });
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        public async Task<int> AddAsync(Order entity)
        {
            entity.Created = DateTime.Now;
            entity.DateTimePlacement = DateTime.Now;
            entity.TakenUpDate = DateTime.Now;
            entity.Created = DateTime.Now;
            var sql = "Insert into Orders (Id,ReferenceNumber,DateTimePlacement,Location,LocationName,Status,EstimatedDeliveryFee,EstimatedDeliveryTime,EstimatedOrderPrice,IsDeliveryFeeSetByCsr,OrderAdditionalComment,IsUrgentDelivery,CustomerId,PartnerOutletResponseThbreach,TakenUpById,TakenUpDate,RiderAssignedById,PaymentMethodId,IsAccepted,AssignedTo,OrderType,Created,CreatedBy) VALUES (@Id,@ReferenceNumber,@DateTimePlacement,@Location,@LocationName,@Status,@EstimatedDeliveryFee,@EstimatedDeliveryTime,@EstimatedOrderPrice,@IsDeliveryFeeSetByCsr,@OrderAdditionalComment,@IsUrgentDelivery,@CustomerId,@PartnerOutletResponseThbreach,@TakenUpById,@TakenUpDate,@RiderAssignedById,@PaymentMethodId,@IsAccepted,@AssignedTo,@OrderType,@Created,@CreatedBy)";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }
        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                var sql = "DELETE FROM Orders WHERE Id = @Id";
                using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();
                    var result = await connection.ExecuteAsync(sql, new { Id = id });
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<int> UpdateAsync(Order entity)
        {
            try
            {
            entity.Updated = DateTime.Now;
            var sql = "UPDATE Orders SET ReferenceNumber = @ReferenceNumber, DateTimePlacement = @DateTimePlacement, Location = @Location, LocationName = @LocationName, Status = @Status, EstimatedDeliveryFee = @EstimatedDeliveryFee, EstimatedDeliveryTime = @EstimatedDeliveryTime, EstimatedOrderPrice = @EstimatedOrderPrice, IsDeliveryFeeSetByCsr = @IsDeliveryFeeSetByCsr,OrderAdditionalComment = @OrderAdditionalComment,IsUrgentDelivery = @IsUrgentDelivery,CustomerId = @CustomerId,PartnerOutletResponseThbreach = @PartnerOutletResponseThbreach,TakenUpById =@TakenUpById,TakenUpDate=@TakenUpDate,RiderAssignedById=@RiderAssignedById,PaymentMethodId=@PaymentMethodId,IsAccepted=@IsAccepted,AssignedTo=@AssignedTo,OrderType=@OrderType, Updated = @Updated  WHERE Id = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
