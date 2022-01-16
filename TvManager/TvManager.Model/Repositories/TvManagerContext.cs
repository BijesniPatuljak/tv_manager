namespace TvManager.Model.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using TvManager.Model.Interfaces;
    using TvManager.Model.Models;

    public class TvManagerContext: DbContext, ITvManagerContext
    {
        public DbSet<Show> Shows { get; set; }
        public DbSet<Ad> Ads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=tvmanager;Username=postgres;Password=password");

        }
    }
}
