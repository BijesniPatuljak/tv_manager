﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace TvManager.View.View
{
    using System.Windows.Forms;
    using TvManager.View.Interfaces;
    using TvManager.Model.Models;




    public partial class ViewSchedule : Form
    {
        struct ScheduleItem_show
        {
            public Show show;
            public TimeSpan max_offset;
            public TimeSpan curr_offset;

            public TimeSpan ad_offset;
            public TimeSpan max_ad_offset;

            public bool fixed_time;
        };

        struct ScheduleItem_Ad
        {
            public Ad ad;
            public TimeSpan max_offset;
            public TimeSpan curr_offset;
            public bool fixed_time;
        };


        private IShowService showService;
        private IAdService adService;


        List<object>? obavezne = MainMenu.emisije_i_reklame;

        private List<ScheduleItem_show> CrossCheckShows(
            List<ScheduleItem_show> shows,
            List<ScheduleItem_show> final)
        {

            if (final.Count > 0)
            {
                var perfectShows = from show in shows
                                   from fin in final
                                   where (show.show.StartTime + show.show.Duration <= fin.show.StartTime ||
                                   show.show.StartTime  > fin.show.StartTime + fin.show.Duration)
                                   select show;



                Debug.WriteLine("           perfectShows:" + perfectShows.Count());

                //If show is crossing some show in final,but crossing it by just a little (< offset) ,then its valid
                var validShows = from show in shows
                                 from fin in final
                                 where (show.show.StartTime < fin.show.StartTime &&
                                   show.show.StartTime + show.show.Duration > fin.show.StartTime &&
                                   show.show.StartTime + show.show.Duration - fin.show.StartTime <= show.max_offset) ||
                                   (show.show.StartTime < fin.show.StartTime + fin.show.Duration &&
                                   show.show.StartTime + show.show.Duration > fin.show.StartTime + fin.show.Duration &&
                                   fin.show.StartTime + fin.show.Duration - fin.show.Duration <= show.max_offset)
                                 select show;

                Debug.WriteLine("           validShows:" + validShows.Count());

                return validShows.ToList().Concat(perfectShows.ToList()).ToList();

            }

            return shows;

        }

        /*
         Function removes some_shows from all_shows (all_shows = shows left to add to schedule),
            and also puts them in final_shows
         
        
         */
        private void ConfirmAndRemoveShows(
            ref List<ScheduleItem_show> all_shows,
            List<ScheduleItem_show> some_shows, 
            ref List<ScheduleItem_show> final)
        {
            foreach (var show in some_shows)
            {
                
                final.Add(show);
            }

            all_shows.RemoveAll(i => some_shows.Contains(i));
        }
        private List<ScheduleItem_show> GetAndRemoveShowsOfPriority(int priority, ref List<ScheduleItem_show> shows)
        {

            var showsOfPriority =
                from show in shows
                where show.show.Priority == priority
                select show;


            var list = showsOfPriority.ToList();

            shows.RemoveAll(i => showsOfPriority.Contains(i));

            return list;
        }


        private List<ScheduleItem_show> GetShowsWrapper()
        {

            string[] maxTimeSpans = { 
                "04:00:00", "04:00:00", 
                "04:00:00", "04:00:00",
                "04:00:00", "04:00:00", 
                "04:00:00", "02:00:00", 
                "00:30:00", "00:10:00" };
            string[] maxAdTimeSpans = {
                "01:00:00", "01:00:00",
                "01:00:00", "01:00:00",
                "01:00:00", "01:00:00",
                "01:00:00", "00:15:00",
                "00:05:00", "00:00:20" };


            var shows = showService.GetAllShows().ToList();


            //prema unosu u MainMenu, postavlja se ekstra veliki prioritet (10) na odabrane showove

            foreach (var item in shows)
            {

                if (obavezne.Contains(item.Name)) item.Priority = 10;
                
            }



            var schedule_show = new List<ScheduleItem_show>();
            foreach (var show in shows)
            {

                if (show.Duration == TimeSpan.FromHours(0))
                {
                    show.Duration = new TimeSpan(2, 0, 0);
                }


                ScheduleItem_show temp = new ScheduleItem_show();
                temp.show = show;
                temp.curr_offset = new TimeSpan();
                temp.ad_offset = new TimeSpan();
                temp.max_offset = TimeSpan.Parse(maxTimeSpans[show.Priority]);
                temp.max_ad_offset = TimeSpan.Parse(maxAdTimeSpans[show.Priority]);
                temp.fixed_time = show.Priority == 9? true:false; //mozes li tu provjeriti i za prioritet 10?

                schedule_show.Add(temp);
            }

            return schedule_show;
        }

        //private List<ScheduleItem_Ad> GetAdsWrapper()
        

        public ViewSchedule(IShowService showService, IAdService adService)
        {

            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

 
            //var schedule_ads = new List<ScheduleItem_Ad>();
            var all_shows = GetShowsWrapper();

            var final_shows = new List <ScheduleItem_show>();


            for(int p = 10; p >= 6; p--)
            {
                Debug.WriteLine("P = " + p);

                Debug.WriteLine("       All shows left <=p:" + all_shows.Count);

                var currentShows = GetAndRemoveShowsOfPriority(p, ref all_shows);

                Debug.WriteLine("       Shows left <p:" + all_shows.Count);
                Debug.WriteLine("       all shows of this p:" + currentShows.Count);

                //ADD DELEGATION TO SMALLER PRIORITY IF NOT VALID
                var valid = CrossCheckShows(currentShows, final_shows);

                Debug.WriteLine("       valid:" + valid.Count);

                ConfirmAndRemoveShows(ref all_shows, valid, ref final_shows);

                

            }

            //Sortira listu prema planiranom vremenu pocetka

            final_shows.Sort((s1, s2) => s1.show.StartTime.CompareTo(s2.show.StartTime));



            foreach (var show in final_shows)
            {
                listBox1.Items.Add(show.show.StartTime.ToString() + " " +show.show.Duration.ToString() + "  " + show.show.Name + " P:" + show.show.Priority);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
