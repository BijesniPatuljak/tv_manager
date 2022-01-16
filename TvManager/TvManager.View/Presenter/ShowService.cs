namespace TvManager.View.Presenter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TvManager.Model.Models;
    using TvManager.View.Interfaces;

    internal class ShowService : IShowService
    {
        public IEnumerable<Show> GetAllShows() => throw new NotImplementedException();
        public Show GetShow(Guid id) => throw new NotImplementedException();
        public void SaveShow(Show show) => throw new NotImplementedException();
    }
}
