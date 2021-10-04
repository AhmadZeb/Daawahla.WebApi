using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daawahla.Core.Entities.Enums
{
   
        public enum ResultType
        {
            [Display(Name = "Success")]
            Success = 1,

            [Display(Name = "Failure")]
            Failure = 2,
        }

        public enum ReturnCode
        {
            [Display(Name = "OK")]
            OK = 200,
            [Display(Name = "NotFound")]
            NotFound = 404,
            [Display(Name = "BadRequest")]
            BadRequest = 400,
            [Display(Name = "Unauthorized")]
            Unauthorized = 401,
            [Display(Name = "InternalServerError")]
            InternalServerError = 500,
            [Display(Name = "Conflict")]
            Conflict = 409,
        }

        public enum UserType
        {
            [Display(Name = "Customer")]
            Customer = 1,
            [Display(Name = "Partner")]
            Partner = 2,
            [Display(Name = "Agent")]
            Agent = 3,
            [Display(Name = "Dawahla")]
            Darewro = 4
        }

        public enum UserStatus
        {
            Inactive = 0,
            Active = 1,
        }

    public enum OrderStatus
    {
        [Display(Name = "New")]
        New = 1,
        [Display(Name = "Placed")]
        Placed = 2,
        [Display(Name = "Rider Assigned")]
        RiderAssigned = 3,
        [Display(Name = "Ride Accepted")]
        RideAccepted = 4,
        [Display(Name = "Delivered")]
        Delivered = 5,
        [Display(Name = "Payment Received")]
        PaymentReceived = 6,
        [Display(Name = "Cancelled")]
        Cancelled = 7,
    }

    public enum OrderToFetch
    {
        Incomming = 1,
        MyAll = 2,
        MyPending = 3,
        MyCompleted = 4,
        MyNew = 5,
        MyAccepted = 6,
        MyPrepared = 7,
        CustomerOrders = 8,
        Placed = 9,
        MyPlaced = 10,
        MyCancelled = 11,
        Accountant = 12,
        AutomatedIncomming = 13,
        AutomatedOnGoing = 14,
        AutomatedCompleted = 15,
        AutomatedCancelled = 16,
        Cancelled = 17
    }


    public enum OrderComponentStatus
    {
        [Display(Name = "New")]
        New = 1,
        [Display(Name = "Pending")]
        Pending = 2,
        [Display(Name = "Accepted")]
        Accepted = 3,
        [Display(Name = "Rejected")]
        Rejected = 4,
        [Display(Name = "Prepared")]
        Prepared = 5,
        [Display(Name = "Picked")]
        Picked = 6,
        [Display(Name = "Cancelled")]
        Cancelled = 7,
    }

    public enum OrderLocationType
    {
        [Display(Name = "Pickup")]
        Pickup = 1,
        [Display(Name = "Delivery")]
        Delivery = 2,
        [Display(Name = "Payment")]
        Payment = 3,
    }

    public enum OrderPackageType
    {
        [Display(Name = "Item")]
        Item = 1,
        [Display(Name = "Product")]
        Product = 2,
    }

    public enum OrderSource
    {
        [Display(Name = "Mobile")]
        Mobile = 1,
        [Display(Name = "Portal")]
        Portal = 2,
    }

    public enum OrderType
    {
        [Display(Name = "Partner")]
        Partner = 1,
        [Display(Name = "General")]
        General = 2,
    }

    public enum WeightCategory
    {
        [Display(Name = "Below One KG")]
        BelowOneKG = 1,
        [Display(Name = "Above One KG")]
        AboveOneKG = 2,

    }
    public enum PartnerStatus : int
    {
        Active = 1,
        Inactive = 2,
    }
    public enum EntityType
    {
        [Display(Name = "Rider")]
        Rider = 1,
        [Display(Name = "Customer")]
        Customer = 2,
        [Display(Name = "Order")]
        Order = 3,
        [Display(Name = "Partner")]
        Partner = 4,
    }

}

