using Microsoft.EntityFrameworkCore;
using sharps_ent.Entity;

namespace sharps_ent.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Bank> Bank { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Deposit> Deposit { get; set; }
        public DbSet<Depositor> Depositor { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<LogOfOperations> LogOfOperations { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Street> Street { get; set; }
        public DbSet<TypeOperation> TypeOperation { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
