using System;
using Premio.Enums;

namespace Premio.Models
{
    public class FacilityBooking
    {
        public string Id { get; set; }
        public int FacilityId { get; set; }
        public Facility Facility { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public BookingStatus Status { get; set; } = BookingStatus.PENDING;
    }
}
