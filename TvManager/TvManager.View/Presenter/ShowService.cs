namespace TvManager.View.Presenter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TvManager.Model.Models;
    using TvManager.Model.Repositories;
    using TvManager.View.Interfaces;

    internal class ShowService : IShowService
    {
        private readonly TvManagerContext dbContext;
        public ShowService(TvManagerContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<Show> GetAllShows() => this.dbContext.Shows.ToList();
        public Show GetShow(Guid id) => this.dbContext.Shows.Single(show => show.Id == id);
        public void SaveShow(Show show) => this.dbContext.Shows.Add(show);
    }
}
