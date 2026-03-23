using Art_Exhibit.Front.Application.Interfaces.Services;
using Art_Exhibit.Front.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Application
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Infrastructure service registrations go here
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
