namespace TvManager.Model.Models
{
    using System;

    public class Show
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan Duration { get; set; }

        public int Priority { get; set; }
    }
}
