using Premio.Enums;

namespace Premio.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Role Role { get; set; } = Role.SA;
        public int? ProfileId { get; set; }
        public Profile Profile { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Annoucement> Annoucements { get; set; }
        public ICollection<FacilityBooking> FacilityBookings { get; set; }
        public ICollection<Parking> Parkings { get; set; }
        public ICollection<Tenant> Tenants { get; set; }
        public RegistrationType RegistrationType { get; set; } = RegistrationType.SELF;
        public string RegisteredById { get; set; }
        public User RegisteredBy { get; set; }
        public ICollection<User> RegisteredUsers { get; set; }
        public ICollection<AccessTransaction> AccessTransactions { get; set; }
        public string EmergencyContact { get; set; }
        public ICollection<VisitorRequest> VisitorRequests { get; set; }
        public ICollection<VisitorRequest> HostRequests { get; set; }
        public ICollection<VisitorRequest> RegisteredVisitorRequests { get; set; }
    }
}
