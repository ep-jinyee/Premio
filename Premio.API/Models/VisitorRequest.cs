using System;
using Premio.Enums;

namespace Premio.Models
{
    public class VisitorRequest
    {
        public int Id { get; set; }
        public string VisitorId { get; set; }
        public User Visitor { get; set; }
        public string HostId { get; set; }
        public User Host { get; set; }
        public string PremiseId { get; set; }
        public Premise Premise { get; set; }
        public string Purpose { get; set; }
        public string Reason { get; set; }
        public VisitorRequestStatus Status { get; set; } = VisitorRequestStatus.PENDING;
        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ApprovedAt { get; set; }
        public RegistrationType RegistrationType { get; set; } = RegistrationType.SELF;
        public string RegisteredById { get; set; }
        public User RegisteredBy { get; set; }
    }
}
