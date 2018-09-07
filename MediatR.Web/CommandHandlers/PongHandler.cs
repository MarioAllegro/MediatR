using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR.Web.Commands;
using MediatR.Web.Data;
using MediatR.Web.Model;

namespace MediatR.Web.CommandHandlers
{
  /// <summary>
  /// The pong class.
  /// </summary>
  public class PongHandler : IRequestHandler<PingCommand, IEnumerable<ProjectModel>>
  {
    private readonly ApplicationDbContext applicationDbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="PongHandler"/> class.
    /// </summary>
    /// <param name="applicationDbContext">The applicationDbContext.</param>
    public PongHandler(ApplicationDbContext applicationDbContext, IMapper mapper)
    {
      this.applicationDbContext = applicationDbContext;
      this.mapper = mapper;
    }

    /// <summary>
    /// The handle.
    /// </summary>
    /// <param name="request">The request.</param>
    /// <param name="cancellationToken">The cancellationToken.</param>
    /// <returns>The <see cref="T:Task{string}"/>.</returns>
    public Task<IEnumerable<ProjectModel>> Handle(PingCommand request, CancellationToken cancellationToken)
    {
      var projectsEntities = this.applicationDbContext.Projects.ToList();
      var projects = this.mapper.Map<IEnumerable<ProjectModel>>(projectsEntities);
      return Task.FromResult(projects);
    }
  }
}
