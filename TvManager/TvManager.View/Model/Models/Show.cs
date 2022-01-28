

namespace TvManager.Model.Models
{
    using System;
    using TvManager.Model.Models;

    public class Show
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public int Priority { get; set; }
    }
}
