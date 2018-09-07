using MediatR.Web.Commands;
using MediatR.Web.Data;

namespace MediatR.Web.CommandHandlers
{
  /// <summary>
  /// The add project handler class.
  /// </summary>
  public class AddProjectHandler : RequestHandler<AddProjectCommand>
  {
    private readonly ApplicationDbContext applicationDbContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="AddProjectHandler"/> class.
    /// </summary>
    /// <param name="applicationDbContext">The applicationDbContext.</param>
    public AddProjectHandler(ApplicationDbContext applicationDbContext) => this.applicationDbContext = applicationDbContext;

    /// <summary>
    /// The handle.
    /// </summary>
    /// <param name="request">The request.</param>
    protected override void Handle(AddProjectCommand request)
    {
      this.applicationDbContext.Projects.Add(new Project { Name = request.projectName });
      this.applicationDbContext.SaveChanges();
    }
  }
}
