using DemoEmployee.Core;
using Microsoft.EntityFrameworkCore;

namespace DemoEmployee.Server.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employee{ get; set; }
    }
}
