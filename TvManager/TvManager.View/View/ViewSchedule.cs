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

        private IShowService showService;
        private IAdService adService;


        List<object>? obavezne = MainMenu.emisije_i_reklame;



        private TimeSpan FindFreeTimeSpan(
            ref List<Show> final,
            TimeSpan preffered,
            TimeSpan duration,
            bool searchForAd =false
            )
        {
            TimeSpan newTimeSpan;

            int step = searchForAd ? 1 : 5;


            for (int i = 5; i < 1000; i += step)
            {
                newTimeSpan = preffered + TimeSpan.FromMinutes(i);

                var collidedShows = from fin in final
                                    where check_collision(
                                        newTimeSpan,
                                        duration,
                                        fin.StartTime,
                                        fin.Duration)
                                    select fin;
                if (collidedShows.Count() == 0)
                {
                    Debug.WriteLine(i + " " + newTimeSpan.ToString() + " " + duration.ToString());

                    foreach (var show in final)
                    {
                        Debug.WriteLine("w           " + show.Name  + show.StartTime);
                    }

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
            return new TimeSpan(0, 0, 0);
        }


        private void CrossCheckAds(
            List<Ad> adsPriorityP,
            ref List<Ad> final,
            ref List<Show> final_shows
            )
        {
            while (adsPriorityP.Count > 0)
            {
                var new_ad = adsPriorityP.First();


                var collidedAds = from fin in final
                                    where
                                    check_collision(
                                        new_ad.StartTime,
                                        new_ad.Duration,
                                        fin.StartTime,
                                        fin.Duration)
                                    select fin;

                var collidedAds2 = from fin in final_shows
                                   where
                                  check_collision(
                                      new_ad.StartTime,
                                      new_ad.Duration,
                                      fin.StartTime,
                                      fin.Duration)
                                  select fin;



                if (collidedAds.Any() || collidedAds2.Any())
                {
                    Debug.WriteLine("collidedShows for " + new_ad.Name + ":" + collidedAds.Count());

                    TimeSpan newTimeSpan = FindFreeTimeSpan(ref final_shows, new_ad.StartTime, new_ad.Duration,true);

                    Debug.WriteLine("found new timespan: " + newTimeSpan.ToString());

                    new_ad.StartTime = newTimeSpan;

                    final.Add(new_ad);

                }
                else
                {
                    Debug.WriteLine("NO collidedShows for" + new_ad.Name);
                    Debug.WriteLine("Adding " + new_ad.Name);
                    


                    final.Add(new_ad);

                    foreach (var item in final)
                    {
                        Debug.WriteLine(item.Name);
                    }


                }

                adsPriorityP.RemoveAt(0);
            }
        }

        private bool check_collision(
            TimeSpan show1_start,
            TimeSpan show1_duration,
            TimeSpan show2_start,
            TimeSpan show2_duration)
        {
            //Debug.WriteLine("comparing: [" + show1_start + ", " + show1_duration + "], [ " + show2_start + ", " + show2_duration + "]");
            return (show1_start <= show2_start &&
                    show1_start + show1_duration >= show2_start) ||
                    (show1_start <= show2_start + show2_duration &&
                    show1_start + show1_duration >= show2_start + show2_duration) ||
                    (show1_start >= show2_start &&
                    show1_start + show1_duration <= show2_start + show2_duration) ||
                    (show2_start >= show1_start &&
                    show2_start + show2_duration <= show1_start + show1_duration);
        }



        private void CrossCheckShows(
            List<Show> showsPriorityP,
            ref List<Show> final
            )
        {

            while(showsPriorityP.Count > 0)
            {
                var new_show = showsPriorityP.First();


                var collidedShows = from fin in final
                                    where 
                                    check_collision(
                                        new_show.StartTime,
                                        new_show.Duration, 
                                        fin.StartTime, 
                                        fin.Duration)
                                    select fin;

                if (collidedShows.Any())
                {
                    Debug.WriteLine("collidedShows for" + new_show.Name + ":" + collidedShows.Count());

                    TimeSpan newTimeSpan = FindFreeTimeSpan(ref final, new_show.StartTime, new_show.Duration);

                    Debug.WriteLine("found new timespan:" + newTimeSpan.ToString());

                    new_show.StartTime = newTimeSpan + TimeSpan.FromMinutes(5);

                    final.Add(new_show);

                }
                else
                {
                    Debug.WriteLine("NO collidedShows for" + new_show.Name + ":" + collidedShows.Count());
                    Debug.WriteLine("Adding " + new_show.Name);
                    final.Add(new_show);

                    foreach (var item in final)
                    {
                        Debug.WriteLine(item.Name);
                    }

                    
                }

                showsPriorityP.RemoveAt(0);
            }

        }



        private List<Ad> GetAndRemoveAdsOfPriority(int p, ref List<Ad> all_ads)
        {
            var adsOfPriority =
                from ad in all_ads
                where ad.Priority == p
                select ad;

            var list = adsOfPriority.ToList();

            all_ads.RemoveAll(i => list.Contains(i));

            return list;
        }

        private List<Show> GetAndRemoveShowsOfPriority(int priority, ref List<Show> shows)
        {

            var showsOfPriority =
                from show in shows
                where show.Priority == priority
                select show;


            var list = showsOfPriority.ToList();

            shows.RemoveAll(i => showsOfPriority.Contains(i));

            return list;
        }



        public ViewSchedule(IShowService showService, IAdService adService)
        {

            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

 
            //var schedule_ads = new List<ScheduleItem_Ad>();
            var all_shows = showService.GetAllShows().ToList();
            var all_ads = adService.GetAds().ToList();

            var final_shows = new List <Show>();
            var final_ads = new List<Ad>();

            for (int p = 10; p >= 6; p--)
            {
                Debug.WriteLine("P = " + p);

                Debug.WriteLine("       All shows left <=p:" + all_shows.Count);

                var currentShows = GetAndRemoveShowsOfPriority(p, ref all_shows);

                Debug.WriteLine("       Shows left <p:" + all_shows.Count);
                Debug.WriteLine("       all shows of this p:" + currentShows.Count);

                foreach(var currentShow in currentShows)
                {
                    Debug.WriteLine("           " + currentShow.Name);
                }

               
                //var valid = CrossCheckShows(currentShows, final_shows);

                CrossCheckShows(currentShows, ref final_shows);

                all_shows.RemoveAll(i => currentShows.Contains(i));  

            }



            for (int p = 10; p >= 8; p--)
            {
                Debug.WriteLine("P = " + p);

                var currentAds = GetAndRemoveAdsOfPriority(p, ref all_ads);


                CrossCheckAds(currentAds, ref final_ads,ref final_shows);

                all_ads.RemoveAll(i => currentAds.Contains(i));


            }

                //Sortira listu prema planiranom vremenu pocetka

               



            foreach (var show in final_shows)
            {
                listBox1.Items.Add(show.StartTime.ToString() + " " +show.Duration.ToString() + "  " + show.Name + " P:" + show.Priority);
            }
            foreach (var ad in final_ads)
            {
                listBox1.Items.Add(ad.StartTime.ToString() + " " + ad.Duration.ToString() + " AD " + ad.Name + " P:" + ad.Priority);
            }

            listBox1.Sorted = true;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
