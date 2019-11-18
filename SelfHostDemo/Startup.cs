using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SelfHostDemo.ServiceConcretes;
using SelfHostDemo.ServiceInterfaces;

namespace SelfHostDemo
{
    public class Startup
    {
        IConfiguration Configuration { get; }
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddSingleton(Configuration);
            services.AddSingleton<ITestService, TestService>();
        }
    }
}
