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
        public Dictionary<int, Ad> ads = new Dictionary<int, Ad>();
        public Dictionary<int, Show> shows = new Dictionary<int, Show>();


    }
}
