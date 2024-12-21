using System;
using Premio.Enums;

namespace Premio.Models
{
    public class AccessRequest
    {
        public Guid Id { get; set; }
        public string Reason { get; set; } = null!;
        public VisitorRequestStatus Status { get; set; } = VisitorRequestStatus.PENDING;
        public DateTime RequestedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ApprovedAt { get; set; }
        public RegistrationType RequestType { get; set; } = RegistrationType.SELF;
        public Guid CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; } = null!;
        public Guid CreatedForUserId { get; set; }
        public User? CreatedForUser { get; set; }
        public Guid ApprovedByUserId { get; set; }
        public User? ApprovedByUser { get; set; }
        public Guid PremiseId { get; set; }
        public Premise Premise { get; set; } = null!;
    }
}
