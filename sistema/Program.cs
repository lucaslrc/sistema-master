using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using sistema.Services;

namespace sistema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mock = new InsertMock();
            mock.InsertNoticia();
            mock.InsertComentario();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
