using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Core.Entities.OrderModel
{
    public class Order
    {
        public long Id { get; set; }
        public long ReferenceNumber { get; set; }
        public DateTime? DateTimePlacement { get; set; }
        public string Location { get; set; }
        public string LocationName { get; set; }
        public int Status { get; set; }
        //public string SpecialInstructions { get; set; }
       // public int Source { get; set; }
        public decimal EstimatedDeliveryFee { get; set; }
        public int EstimatedDeliveryTime { get; set; }
        public decimal? EstimatedOrderPrice { get; set; }
        public bool IsDeliveryFeeSetByCsr { get; set; }
        //public DateTime? ScheduledDateTime { get; set; }
        public string OrderAdditionalComment { get; set; }
        public bool IsUrgentDelivery { get; set; }
        public long CustomerId { get; set; }
        public bool? PartnerOutletResponseThbreach { get; set; }
        public long? TakenUpById { get; set; }
        public DateTime? TakenUpDate { get; set; }
        public long? RiderAssignedById { get; set; }
        public long PaymentMethodId { get; set; }
        public bool? IsAccepted { get; set; }
        public long? AssignedTo { get; set; }
       // public bool IsCommitted { get; set; }
        public int OrderType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public long CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
