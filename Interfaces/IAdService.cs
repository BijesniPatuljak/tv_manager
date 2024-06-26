﻿namespace TvManager.View.Interfaces
{
    using System;
    using System.Collections.Generic;
    using TvManager.Model.Models;

    public interface IAdService
    {
        IEnumerable<Ad> GetAds();
        Ad GetAd(Guid adId);
        void SaveAd(Ad ad);
    }
}
