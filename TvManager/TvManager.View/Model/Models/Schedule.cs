using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvManager.Model.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TvManager.Model.Models
{
    [NotMapped]
    internal class Schedule
    {
        public Dictionary<TimeSpan, Ad> ads = new Dictionary<TimeSpan, Ad>();
        public Dictionary<TimeSpan, Show> shows = new Dictionary<TimeSpan, Show>();


    }
}
