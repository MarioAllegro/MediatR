namespace MediatR.Web.Data
{
  /// <summary>
  /// The project class.
  /// </summary>
  public class Project
  {
    public int ProjectId { get; set; }
    public string Name { get; internal set; }
  }
}