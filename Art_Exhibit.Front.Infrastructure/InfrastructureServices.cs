using Art_Exhibit.Front.Application.Interfaces.HttpClients;
using Art_Exhibit.Front.Infrastructure.HttpClients;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Art_Exhibit.Front.Infrastructure
{
    public static class InfrastructureServicesExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Infrastructure service registrations go here
            services.AddHttpClient<IUserClient, UserClient>(client =>
                client.BaseAddress = new Uri("https://localhost:7007/api/"));

            // services.AddScoped<IProductClient, ProductClient>();
            return services;
        }
    }
}
