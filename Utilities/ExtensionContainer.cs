using ExamPortal.DTOS;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPortal.Utilities
{
    public static class ExtensionContainer
    {
        public static IServiceCollection configureDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
