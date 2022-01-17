namespace TvManager.View
{

    using Microsoft.Extensions.DependencyInjection;
    using TvManager.Model.Repositories;
    using TvManager.View.Interfaces;
    using TvManager.View.Presenter;
    using System.Windows.Forms;
    using System;
    using TvManager.View.View;

    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            services.AddScoped<MainMenu>();
            services.AddScoped<ViewAds>();
            services.AddScoped<ViewShows>();
            services.AddScoped<EditAd>();
            services.AddScoped<EditShow>();
            services.AddScoped<GenerateSchedule>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainMenuForm = serviceProvider.GetRequiredService<MainMenu>();
                Application.Run(mainMenuForm);

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