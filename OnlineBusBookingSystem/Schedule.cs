//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineBusBookingSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            this.BookedLists = new HashSet<BookedList>();
        }
    
        public int BusId { get; set; }
        public int ScheduleId { get; set; }
        public string BusName { get; set; }
        public System.DateTime Departure { get; set; }
        public System.DateTime Arrival { get; set; }
        public int Availability { get; set; }
        public int Price { get; set; }
        public int FromLocationId { get; set; }
        public int ToLocationId { get; set; }
    
        public virtual BusList BusList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookedList> BookedLists { get; set; }
        public virtual LocationList LocationList { get; set; }
        public virtual LocationList LocationList1 { get; set; }
    }
}