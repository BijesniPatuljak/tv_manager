namespace TvManager.View.Interfaces
{
    using System;
    using System.Collections.Generic;
    using TvManager.Model.Models;

    public interface IShowService
    {
        IEnumerable<Show> GetAllShows();
        Show GetShow(Guid id);
        void SaveShow(Show show);
    }
}
