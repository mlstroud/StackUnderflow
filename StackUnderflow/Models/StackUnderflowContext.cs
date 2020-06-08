using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StackUnderflow.Models
{
  public class StackUnderflowContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Forum> Forums { get; set; }
    public virtual DbSet<Thread> Threads { get; set; }
    public virtual DbSet<Post> Posts { get; set; }
    public StackUnderflowContext(DbContextOptions options) : base(options) { }
  }
}