using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set }
    public DbSet<EnigneerMachine> EnigneerMachine { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}