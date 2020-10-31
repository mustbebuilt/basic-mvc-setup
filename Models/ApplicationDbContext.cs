using <YOUR-PROJECT-NAME>.Models;
using Microsoft.EntityFrameworkCore;

namespace <YOUR-PROJECT-NAME>.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}


