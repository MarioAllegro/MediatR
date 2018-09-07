using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR.Web.CommandHandlers;
using MediatR.Web.Data;
using MediatR.Web.Model;

namespace MediatR.Web
{
  /// <summary>
  /// The mapping profile class.
  /// </summary>
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      this.CreateMap<Project, ProjectModel>();
    }
  }
}
