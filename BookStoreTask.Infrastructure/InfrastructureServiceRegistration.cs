using BookStoreTask.Application.Contracts.Infrastructure;
using BookStoreTask.Infrastructure.FileExport;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreTask.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddTransient<ICsvExporter, CsvExporter>(); 

            return services;
        }
    }
}
