using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace MediatR.Web.Data
{
  /// <summary>
  /// The application db context class.
  /// </summary>
  public class ApplicationDbContext : DbContext
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options) {}

    public DbSet<Project> Projects { get; set; }
  }
}