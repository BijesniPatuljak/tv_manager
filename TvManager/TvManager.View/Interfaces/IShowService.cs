namespace TvManager.View.Interfaces
{
    using TvManager.Model.Models;

    public interface IShowService
    {
        IEnumerable<Show> GetAllShows();
        Show GetShow(Guid id);
        void SaveShow(Show show);
    }
}
