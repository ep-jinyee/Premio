using System;
using Premio.Enums;

namespace Premio.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string? ProfilePicture { get; set; }
        public required string Address1 { get; set; }
        public string? Address2 { get; set; }
        public required string Postcode { get; set; }
        public MY_STATE State { get; set; } = MY_STATE.UNDEFINED;
        public string Country { get; set; } = "Malaysia";
        public string? UserId { get; set; }
        public required User User { get; set; }
    }
}
