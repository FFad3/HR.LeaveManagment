using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HR.LeaveManagment.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
