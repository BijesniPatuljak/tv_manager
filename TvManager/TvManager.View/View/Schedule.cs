using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvManager.Model.Models;

namespace TvManager.View.View
{

    public class ScheduleItem
    {


        public DateTime StartTime { get; set; }
        public TimeSpan Duration{ get; set; }
    }

    internal class Schedule
    {
        public Dictionary<int, Ad> ads = new Dictionary<int, Ad>();
        public Dictionary<int, Show> shows = new Dictionary<int, Show>();


    }
}
