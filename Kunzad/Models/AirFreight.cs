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
    
    public partial class AirFreight
    {
        public AirFreight()
        {
            this.AirFreightShipments = new HashSet<AirFreightShipment>();
        }
    
        public int Id { get; set; }
        public int AirLineId { get; set; }
        public string AirWaybillNumber { get; set; }
        public Nullable<System.DateTime> AirWaybillDate { get; set; }
        public System.DateTime EstimatedDepartureDate { get; set; }
        public System.TimeSpan EstimatedDepartureTime { get; set; }
        public System.DateTime EstimatedArrivalDate { get; set; }
        public System.TimeSpan EstimatedArrivalTime { get; set; }
        public int OriginBusinessUnitId { get; set; }
        public int DestinationBusinessUnitId { get; set; }
        public Nullable<System.DateTime> DepartureDate { get; set; }
        public Nullable<System.TimeSpan> DepartureTime { get; set; }
        public Nullable<System.DateTime> ArrivalDate { get; set; }
        public Nullable<System.TimeSpan> ArrivalTime { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<int> LastUpdatedByUserId { get; set; }
    
        public virtual AirLine AirLine { get; set; }
        public virtual BusinessUnit BusinessUnit { get; set; }
        public virtual BusinessUnit BusinessUnit1 { get; set; }
        public virtual ICollection<AirFreightShipment> AirFreightShipments { get; set; }
    }
}
