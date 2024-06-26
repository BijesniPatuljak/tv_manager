﻿namespace TvManager.View.Presenter
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



        public void DeleteAd(Ad ad)
        {
            this.dbContext.Remove(ad);
            this.dbContext.SaveChanges();
        }

        public void DeleteAllAds()
        {
            this.dbContext.RemoveRange(dbContext.Ads);
            this.dbContext.SaveChanges();
        }

        public Ad GetAd(Guid adId) => this.dbContext.Ads.Single(ad => ad.Id == adId);
        public IEnumerable<Ad> GetAds() => this.dbContext.Ads.ToList();
        public void SaveAd(Ad ad)
        {
            this.dbContext.Ads.Add(ad);
            this.dbContext.SaveChanges();
        }

        public void UpdateAd(Ad old, Ad new_ad)
        {
            this.DeleteAd(old);
            this.SaveAd(new_ad);
            this.dbContext.SaveChanges();

        }
    }
}
