using Microsoft.Extensions.Configuration;
using SelfHostDemo.ServiceInterfaces;
using System;

namespace SelfHostDemo.ServiceConcretes
{
    class TestService : ITestService
    {
        private readonly IConfiguration _configuration;

        public TestService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void SayMyName()
        {
            var myName = _configuration["root:myname"];
            Console.WriteLine(myName);
        }
    }
}
