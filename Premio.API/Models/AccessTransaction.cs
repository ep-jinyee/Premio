using Premio.Enums;

namespace Premio.Models
{
    public class AccessTransaction
    {
        public int Id { get; set; }
        public required string VisitorId { get; set; }
        public required User Visitor { get; set; }

        public string PremiseId { get; set; }
        public required Premise Premise { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
        public AccessStatus Status { get; set; } = AccessStatus.CHECKED_IN;
        public int? GateId { get; set; }
        public required Gate Gate { get; set; }
    }
}
