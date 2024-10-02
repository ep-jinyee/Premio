using System;
using System.Collections.Generic;

namespace Premio.Models
{
    public class Facility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public string PremiseId { get; set; }
        public Premise Premise { get; set; }
        public int? FacilityCategoryId { get; set; }
        public FacilityCategory FacilityCategory { get; set; }
        public ICollection<FacilityBooking> FacilityBookings { get; set; }
    }
}
