using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public dbSet<Engineer> Engineers { get; set; }
    public dbSet<Machine> Machines { get; set; }
    public dbSet<EngineerMachine> EngineerMachines { get; set; }
    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}