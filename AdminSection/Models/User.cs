using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AdminSection.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
