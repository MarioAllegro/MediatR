namespace MediatR.Web.Commands
{
  /// <summary>
  /// The add project command class.
  /// </summary>
  public class AddProjectCommand : IRequest
  {
    public readonly string projectName;

    public AddProjectCommand(string projectName)
    {
      this.projectName = projectName;
    }
  }
}
