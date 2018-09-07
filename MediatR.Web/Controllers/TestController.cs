using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR.Web.Commands;
using MediatR.Web.Model;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Web.Controllers
{
  /// <summary>
  /// The test controller class.
  /// </summary>
  [Route("api/[controller]")]
  [ApiController]
  public class TestController : ControllerBase
  {
    public TestController(IMediator mediator) => this.Mediator = mediator;

    /// <summary>
    /// Gets the mediator.
    /// </summary>
    private IMediator Mediator { get; }

    // GET api/values
    /// <summary>
    /// Get.
    /// </summary>
    [HttpGet]
    public Task<IEnumerable<ProjectModel>> GetAsync() => this.Mediator.Send(new PingCommand("test"));

    [HttpPost]
    [Route("Add")]
    public void AddProject(AddProjectCommand addProjectCommand) => this.Mediator.Send(addProjectCommand);
  }
}