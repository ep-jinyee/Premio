using Microsoft.AspNetCore.Identity;
using Premio.Enums;

namespace Premio.Models
{
    public class User : IdentityUser
    {

        public Profile? Profile { get; set; }
        public Tenant? Tenant { get; set; }
    }
}
