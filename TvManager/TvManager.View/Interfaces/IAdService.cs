namespace TvManager.View.Interfaces
{
    using TvManager.Model.Models;

    public interface IAdService
    {
        IEnumerable<Ad> GetAds();
        Ad GetAd(Guid adId);
        void SaveAd(Ad ad);
    }
}
