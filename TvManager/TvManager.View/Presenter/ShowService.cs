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

        public void DeleteShow(Show show)
        {
            this.dbContext.Remove(show);
            this.dbContext.SaveChanges();
        }

        public void DeleteAllShows()
        {
            this.dbContext.RemoveRange(dbContext.Shows);
            this.dbContext.SaveChanges();
        }
        public IEnumerable<Show> GetAllShows() => this.dbContext.Shows.ToList();
        public Show GetShow(Guid id) => this.dbContext.Shows.Single(show => show.Id == id);
        public void SaveShow(Show show)
        {
            this.dbContext.Add(show);
            this.dbContext.SaveChanges();
        } 
    }
}
