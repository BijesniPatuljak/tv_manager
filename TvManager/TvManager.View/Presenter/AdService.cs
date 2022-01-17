namespace TvManager.View.Presenter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TvManager.Model.Models;
    using TvManager.Model.Repositories;
    using TvManager.View.Interfaces;

    internal class AdService : IAdService
    {
        private readonly TvManagerContext dbContext;
        public AdService(TvManagerContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Ad GetAd(Guid adId) => this.dbContext.Ads.Single(ad => ad.Id == adId);
        public IEnumerable<Ad> GetAds() => this.dbContext.Ads.ToList();
        public void SaveAd(Ad ad)
        {
            this.dbContext.Ads.Add(ad);
            this.dbContext.SaveChanges();
        }
    }
}
