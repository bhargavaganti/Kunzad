//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kunzad.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TruckingDelivery
    {
        public int Id { get; set; }
        public int TruckingId { get; set; }
        public int ShipmentId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerDocumentNo { get; set; }
        public short Quantity { get; set; }
        public decimal CBM { get; set; }
        public string Description { get; set; }
        public string DeliverTo { get; set; }
        public Nullable<int> DeliveryAddressId { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<System.TimeSpan> DeliveryTime { get; set; }
        public decimal CostAllocation { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<int> LastUpdatedByUserId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Shipment Shipment { get; set; }
        public virtual Trucking Trucking { get; set; }
    }
}
