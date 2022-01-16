namespace TvManager.View.Interfaces
{
    using TvManager.Model.Models;

    public interface IAdService
    {
        IEnumerable<Ad> GetAds(Guid adId);
        Ad GetAd(Guid adId);
        void SaveAd(Ad ad);
    }
}
