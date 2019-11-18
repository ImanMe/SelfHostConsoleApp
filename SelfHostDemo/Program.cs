using Microsoft.Extensions.DependencyInjection;
using SelfHostDemo.ServiceInterfaces;

namespace SelfHostDemo
{
    class Program
    {
        public static void Main()
        {
            var startup = new Startup();
            var services = new ServiceCollection();
            
            startup.ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();                     

            // Get Service and call method
            var service = serviceProvider.GetService<ITestService>();
            service.SayMyName();
        }
    }
}
