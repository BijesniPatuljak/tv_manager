using System;
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



        private TimeSpan FindFreeTimeSpan(
            ref List<ScheduleItem_show> final,
            TimeSpan preffered,
            TimeSpan duration
            )
        {
            TimeSpan newTimeSpan;

            for (int i = 5; i < 1000; i+=5)
            {
                newTimeSpan = preffered + TimeSpan.FromMinutes(i);

                var collidedShows = from fin in final
                                    where (newTimeSpan < fin.show.StartTime &&
                                   newTimeSpan + duration > fin.show.StartTime) ||
                                   (newTimeSpan < fin.show.StartTime + fin.show.Duration &&
                                   newTimeSpan + duration > fin.show.StartTime + fin.show.Duration)
                                    select fin;
                if (collidedShows.Count() == 0)
                {
                    Debug.WriteLine(i +" " + newTimeSpan.ToString()+" " + duration.ToString());
                    return newTimeSpan;
                }

                //newTimeSpan = preffered - TimeSpan.FromMinutes(i);

                //var collidedShows2 = from fin in final
                //                    where (newTimeSpan < fin.show.StartTime &&
                //                   newTimeSpan + duration > fin.show.StartTime) ||
                //                   (newTimeSpan < fin.show.StartTime + fin.show.Duration &&
                //                   newTimeSpan + duration > fin.show.StartTime + fin.show.Duration)
                //                    select fin;
                //if (collidedShows2.Count() == 0)
                //{
                //    Debug.WriteLine(i + " " + newTimeSpan.ToString() + " " + duration.ToString());
                //    return newTimeSpan;
                //}


            }
            return new TimeSpan(0,0,0);
        }

        private void CrossCheckShows2(
            List<ScheduleItem_show> showsPriorityP,
            ref List<ScheduleItem_show> final
            )
        {

            while(showsPriorityP.Count > 0)
            {
                var new_show = showsPriorityP.First();


                var collidedShows = from fin in final
                                    where (new_show.show.StartTime <= fin.show.StartTime &&
                                   new_show.show.StartTime + new_show.show.Duration >= fin.show.StartTime ) ||
                                   (new_show.show.StartTime <= fin.show.StartTime + fin.show.Duration &&
                                   new_show.show.StartTime + new_show.show.Duration >= fin.show.StartTime + fin.show.Duration)
                                    select fin;

                if (collidedShows.Any())
                {
                    Debug.WriteLine("collidedShows for" + new_show.show.Name + ":" + collidedShows.Count());

                    TimeSpan newTimeSpan = FindFreeTimeSpan(ref final, new_show.show.StartTime, new_show.show.Duration);

                    Debug.WriteLine("found new timespan:" + newTimeSpan.ToString());

                    new_show.show.StartTime = newTimeSpan;

                    final.Add(new_show);

                }
                else
                {
                    Debug.WriteLine("NO collidedShows for" + new_show.show.Name + ":" + collidedShows.Count());
                    Debug.WriteLine("Adding " + new_show.show.Name);
                    final.Add(new_show);

                    foreach (var item in final)
                    {
                        Debug.WriteLine(item.show.Name);
                    }

                    
                }

                showsPriorityP.RemoveAt(0);
            }




        }

        private List<ScheduleItem_show> CrossCheckShows(
            List<ScheduleItem_show> shows,
            List<ScheduleItem_show> final)
        {

            if (final.Count > 0)
            {

                // if show fits perfectly in the schedule without additional movements
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


            for(int p = 10; p >= 8; p--)
            {
                Debug.WriteLine("P = " + p);

                Debug.WriteLine("       All shows left <=p:" + all_shows.Count);

                var currentShows = GetAndRemoveShowsOfPriority(p, ref all_shows);

                Debug.WriteLine("       Shows left <p:" + all_shows.Count);
                Debug.WriteLine("       all shows of this p:" + currentShows.Count);

                foreach(var currentShow in currentShows)
                {
                    Debug.WriteLine("           " + currentShow.show.Name);
                }

                //ADD DELEGATION TO SMALLER PRIORITY IF NOT VALID


                //var valid = CrossCheckShows(currentShows, final_shows);

                CrossCheckShows2(currentShows, ref final_shows);



               // Debug.WriteLine("       valid:" + valid.Count);

                //foreach (var currentShow in valid)
                //{
                //    Debug.WriteLine("           " + currentShow.show.Name);
                //}

                all_shows.RemoveAll(i => currentShows.Contains(i));

                //ConfirmAndRemoveShows(ref all_shows, valid, ref final_shows);

                

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
