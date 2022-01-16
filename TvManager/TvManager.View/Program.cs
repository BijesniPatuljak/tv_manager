namespace TvManager.View
{
    using Microsoft.Extensions.DependencyInjection;
    using TvManager.Model.Repositories;
    using TvManager.View.Interfaces;
    using TvManager.View.Presenter;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);

            services.AddScoped<Form1>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);

            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IShowService, ShowService>()
                    .AddScoped<IAdService, AdService>()
                    .AddDbContext<TvManagerContext>();
        }
    }
}