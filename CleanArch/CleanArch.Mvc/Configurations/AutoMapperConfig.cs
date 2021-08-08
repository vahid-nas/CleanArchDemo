﻿using CleanArch.Application.Automappers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Configurations
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArch.Application.Automappers.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }
    }

}
