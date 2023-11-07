using GeneralUpdate.SystemService.services;

namespace GeneralUpdate.SystemService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddHostedService<RestoreService>();
            var host = builder.Build();
            host.Run();
        }
    }
}