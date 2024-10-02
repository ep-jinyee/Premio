using System;
using Premio.Enums;

namespace Premio.Models
{
    public class Profile
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicture { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Postcode { get; set; }
        public MY_STATE State { get; set; } = MY_STATE.UNDEFINED;
        public string Country { get; set; } = "Malaysia";
        public User User { get; set; }
    }
}
