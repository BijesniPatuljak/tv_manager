namespace TvManager.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Ad
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan StartTime { get; set; }

        public int Priority { get; set; }
        public decimal Cost { get; set; }

    }
}
