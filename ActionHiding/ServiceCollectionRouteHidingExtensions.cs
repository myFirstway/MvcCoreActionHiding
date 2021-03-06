﻿using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace ActionHiding
{
    public static class ServiceCollectionRouteHidingExtensions
    {
        public static IMvcBuilder AddRouteHiding(this IMvcBuilder mvcBuilder, IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));
            services.TryAddEnumerable(ServiceDescriptor.Transient<IActionDescriptorProvider, RouteHidingActionDescriptorProvider>());
            return mvcBuilder;
        }
    }
}
