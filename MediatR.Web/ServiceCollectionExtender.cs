using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MediatR.Web
{
  public static class ServiceCollectionExtender
  {
    public static void AddAutoMapper(this IServiceCollection services, IEnumerable<Assembly> assembliesToScan)
    {
      assembliesToScan = assembliesToScan as Assembly[] ?? assembliesToScan.ToArray();

      var allTypes = assembliesToScan.SelectMany(a => a.ExportedTypes).ToArray();

      var profiles = allTypes.Where(t =>
      typeof(Profile).GetTypeInfo().IsAssignableFrom(t.GetTypeInfo())
      && !t.GetTypeInfo().IsAbstract);

      Mapper.Initialize(cfg =>
      {
        foreach (var profile in profiles)
        {
          cfg.AddProfile(profile);
        }
      });
    }
  }
}
