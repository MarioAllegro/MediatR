using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR.Web.Commands;
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
    public TestController(IMediator mediator)
    {
      this.Mediator = mediator;
    }

    /// <summary>
    /// Gets the mediator.
    /// </summary>
    IMediator Mediator { get; }

    // GET api/values
    /// <summary>
    /// Get.
    /// </summary>
    /// <returns>The <see cref="T:ActionResult{IEnumerable{string}}"/>.</returns>
    [HttpGet]
    public async Task<string> GetAsync()
    {
      var pingCommandPromise = this.Mediator.Send(new PingCommand("test"));
      return await pingCommandPromise;
    }
  }
}