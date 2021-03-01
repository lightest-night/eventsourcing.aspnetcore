using System;
using System.Linq;
using System.Reflection;
using LightestNight.EventSourcing.Events;
using Microsoft.Extensions.Hosting;

namespace LightestNight.EventSourcing.AspNetCore
{
    public static class ExtendsHost
    {
        public static IHost UseEventSourcing(this IHost host, params Assembly[] assemblies)
        {
            EventCollection.AddAssemblyTypes(assemblies);
            return host;
        }

        public static IHost UseEventSourcing(this IHost host, params Type[] pointerTypes)
        {
            EventCollection.AddAssemblyTypes(pointerTypes.Select(type => type.Assembly).ToArray());
            return host;
        }
    }
}