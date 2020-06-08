using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StackUnderflow.Models
{
  public class StackUnderflowContext : IdentityDbContext<ApplicationUser>
  {

    public StackUnderflowContext(DbContextOptions options) : base(options) { }
  }
}