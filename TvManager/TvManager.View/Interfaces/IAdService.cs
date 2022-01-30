namespace TvManager.View.Interfaces
{
    using System;
    using System.Collections.Generic;
    using TvManager.Model.Models;

    public interface IAdService
    {

        void DeleteAd(Ad ad);

        void UpdateAd(Ad old,Ad new_ad);

        void DeleteAllAds();

        IEnumerable<Ad> GetAds();
        Ad GetAd(Guid adId);
        void SaveAd(Ad ad);
    }
}
