﻿using System;
using System.Linq;
using System.Reflection;
using LightestNight.System.EventSourcing.Events;
using Microsoft.AspNetCore.Builder;

namespace LightestNight.System.EventSourcing.AspNetCore
{
    public static class ExtendsApplicationBuilder
    {
        public static IApplicationBuilder UseEventSourcing(this IApplicationBuilder appBuilder,
            params Assembly[] assemblies)
        {
            EventCollection.AddAssemblyTypes(assemblies);
            return appBuilder;
        }

        public static IApplicationBuilder UseEventSourcing(this IApplicationBuilder appBuilder,
            params Type[] pointerTypes)
        {
            EventCollection.AddAssemblyTypes(pointerTypes.Select(type => type.Assembly).ToArray());
            return appBuilder;
        }
    }
}