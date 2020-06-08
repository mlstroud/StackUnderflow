using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace StackUnderflow.Models
{
  public class StackUnderflowContextFactory : IDesignTimeDbContextFactory<StackUnderflowContext>
  {
    StackUnderflowContext IDesignTimeDbContextFactory<StackUnderflowContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<StackUnderflowContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new StackUnderflowContext(builder.Options);
    }
  }
}