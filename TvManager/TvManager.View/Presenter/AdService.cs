namespace TvManager.View.Presenter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TvManager.Model.Models;
    using TvManager.View.Interfaces;

    internal class AdService : IAdService
    {
        public Ad GetAd(Guid adId) => throw new NotImplementedException();
        public IEnumerable<Ad> GetAds(Guid adId) => throw new NotImplementedException();
        public void SaveAd(Ad ad) => throw new NotImplementedException();
    }
}
