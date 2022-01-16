namespace TvManager.Model.Contracts
{
    using TvManager.Model.Models;

    public interface IShowRepository
    {
        IEnumerable<Show> GetAllShows();
        Show GetById(Guid id);
        void SaveShow(Show show);
    }
}