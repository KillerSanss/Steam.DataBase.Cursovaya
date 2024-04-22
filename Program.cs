using Microsoft.Extensions.DependencyInjection;
using steam.Infrastructure.Context;

namespace steam
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = new ServiceCollection()
                .AddDbContext<SteamDbContext>()
                .AddTransient<Form4>() 
                .BuildServiceProvider();

            var form = serviceProvider.GetRequiredService<Form4>();

            Application.Run(form);
        }
    }
}