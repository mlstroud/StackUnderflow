using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StackUnderflow.Models
{
  public class StackUnderflowContext : IdentityDbContext<ApplicationUser>
  {

  }
}