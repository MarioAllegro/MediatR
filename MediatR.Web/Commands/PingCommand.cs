using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.Web.Commands
{
  /// <summary>
  /// The ping command class.
  /// </summary>
  public class PingCommand : IRequest<string>
  {
    /// <summary>
    /// The message (readonly).
    /// </summary>
    public string Message;

    /// <summary>
    /// Initializes a new instance of the <see cref="PingCommand"/> class.
    /// </summary>
    public PingCommand(string message) => this.Message = message;
  }
}