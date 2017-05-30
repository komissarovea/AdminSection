using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminSection.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        // public ApplicationContext() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
    }
}
