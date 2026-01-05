using Microsoft.EntityFrameworkCore;
using Web_Api_Phase1.Model;

namespace Web_Api_Phase1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {}
        public DbSet<Employee> Employees { get; set; }
    }
}
