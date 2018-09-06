using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR.Web.Commands;

namespace MediatR.Web.CommandHandlers
{
  /// <summary>
  /// The pong class.
  /// </summary>
  public class PongHandler : IRequestHandler<PingCommand, string>
  {
    /// <summary>
    /// The handle.
    /// </summary>
    /// <param name="request">The request.</param>
    /// <param name="cancellationToken">The cancellationToken.</param>
    /// <returns>The <see cref="T:Task{string}"/>.</returns>
    public Task<string> Handle(PingCommand request, CancellationToken cancellationToken)
    {
      return Task.FromResult(request.Message);
    }
  }
}
