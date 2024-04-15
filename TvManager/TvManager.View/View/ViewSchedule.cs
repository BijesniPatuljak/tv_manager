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
using System.IO;


namespace TvManager.View.View
{
    using System.Windows.Forms;
    using TvManager.View.Interfaces;
    using TvManager.Model.Models;




    public partial class ViewSchedule : Form
    {

        private IShowService showService;
        private IAdService adService;

        public List<Show> final_shows = new List<Show>();
        public List<Ad> final_ads = new List<Ad>();


        public ViewSchedule(IShowService showService, IAdService adService)
        {

            this.showService = showService;
            this.adService = adService;
            InitializeComponent();


            //dohvacanje servisa kroz koje se updejta baza
            var all_shows = showService.GetAllShows().ToList();
            var all_ads = adService.GetAds().ToList();


            //prodi kroz sve prioritete Showova
            for (int p = 10; p >= 3; p--)
            {

                //uzmi sve Showove prioriteta p
                var currentShows = GetAndRemoveShowsOfPriority(p, ref all_shows);

                //redom ih ubacuj u final_shows,ako treba promijeni termin ako ne stane
                CrossCheckShows(currentShows, ref final_shows);

                //makni ih iz popisa preostalih Showova
                all_shows.RemoveAll(i => currentShows.Contains(i));
            }


            //Ads: isto kao za Shows
            for (int p = 10; p >= 3; p--)
            {
                Debug.WriteLine("P = " + p);

                var currentAds = GetAndRemoveAdsOfPriority(p, ref all_ads);

                CrossCheckAds(currentAds, ref final_ads, ref final_shows);

                all_ads.RemoveAll(i => currentAds.Contains(i));


            }

            //ispisi u tablicu ono sto se dobije u final_shows/final_ads
            foreach (var show in final_shows)
            {
                string[] row = {
                    show.Name,
                    show.StartTime.ToString(),
                    show.Duration.ToString() };


                result_table.Rows.Add(row);
            }
            foreach (var ad in final_ads)
            {
                string[] row = {
                    ad.Name,
                    ad.StartTime.ToString(),
                    ad.Duration.ToString() };

                result_table.Rows.Add(row);
            }

            result_table.Sort(result_table.Columns["ResultStartTime"], ListSortDirection.Ascending);


        }

        //nadi dobar termin za show/ad (gleda sve vec spremljene showove u final
        //te trazi dobar termin)
        private TimeSpan FindFreeTimeSpan(
            ref List<Show> final,
            TimeSpan preffered,
            TimeSpan duration,
            bool searchForAd =false,
            List<Ad> final_ads = null
            )
        {

            TimeSpan newTimeSpan;
            int step = searchForAd ? 1 : 5;
 
            //iterira po vremenu u periodima od 1 ili 5 minuta i gleda jel se termin preklapa
            for (int i = step; i < 1000; i += step)
            {
                newTimeSpan = preffered + TimeSpan.FromMinutes(i);

                var collidedShows = from fin in final
                                    where check_collision(
                                        newTimeSpan,
                                        duration,
                                        fin.StartTime,
                                        fin.Duration)
                                    select fin.Id;

                if (searchForAd)
                {
                     var collidedAds = from fin in final_ads
                                       where check_collision(
                                            newTimeSpan,
                                            duration,
                                            fin.StartTime,
                                            fin.Duration)
                                        select fin.Id;

                    collidedShows = collidedShows.Concat(collidedAds);
                }
                   



                if (collidedShows.Count() == 0)
                {
                    

                    return newTimeSpan;
                }

                newTimeSpan = preffered - TimeSpan.FromMinutes(i);

                var collidedShows2 = from fin in final
                                    where check_collision(
                                        newTimeSpan,
                                        duration,
                                        fin.StartTime,
                                        fin.Duration)
                                    select fin.Name;

                if (searchForAd)
                {
                    var collidedAds = from fin in final_ads
                                      where check_collision(
                                           newTimeSpan,
                                           duration,
                                           fin.StartTime,
                                           fin.Duration)
                                      select fin.Name;

                   

                    collidedShows2 = collidedShows2.Concat(collidedAds);
                }

                if (collidedShows2.Count() == 0)
                {
                    return newTimeSpan;
                }


            }
            return new TimeSpan(0, 0, 0);
        }

        //gura Adse u final_ads jedan po jedan,te premjesta termin ako je potrebno
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
                   
                   

                    TimeSpan newTimeSpan = FindFreeTimeSpan(
                        ref final_shows, 
                        new_ad.StartTime, 
                        new_ad.Duration,
                        true,
                        final);

                   

                    new_ad.StartTime = newTimeSpan;

                    final.Add(new_ad);

                }
                else
                {
                    
                    final.Add(new_ad);
                }

                
                adsPriorityP.RemoveAt(0);
            }
        }



        //provjerava koliju izmedu 2 termina, vraca true ako kolizija postoji,false inace
        private bool check_collision(
            TimeSpan show1_start,
            TimeSpan show1_duration,
            TimeSpan show2_start,
            TimeSpan show2_duration)
        {

            var rez = (show1_start < show2_start && show1_start + show1_duration > show2_start) ||
                    (show1_start < show2_start + show2_duration && show1_start + show1_duration > show2_start + show2_duration) ||
                    (show1_start > show2_start && show1_start + show1_duration < show2_start + show2_duration) ||
                    (show2_start > show1_start && show2_start + show2_duration < show1_start + show1_duration) ||
                    (show1_start == show2_start) ||
                    (show1_start + show1_duration == show2_start + show2_duration);
                    

        
            return rez;
        }


        //identicno kao za Ads
        private void CrossCheckShows(
            List<Show> showsPriorityP,
            ref List<Show> final
            )
        {

            while(showsPriorityP.Count > 0)
            {
               

                var new_show = new Show();
                new_show.Priority = showsPriorityP.First().Priority;
                new_show.Name = showsPriorityP.First().Name;
                new_show.Duration = showsPriorityP.First().Duration;
                new_show.StartTime = showsPriorityP.First().StartTime;
                new_show.Id = showsPriorityP.First().Id;

                var collidedShows = from fin in final
                                    where 
                                    check_collision(
                                        new_show.StartTime,
                                        new_show.Duration, 
                                        fin.StartTime, 
                                        fin.Duration)
                                    select fin;




                if (collidedShows.Count() > 0)
                {
                    
                    TimeSpan newTimeSpan = FindFreeTimeSpan(
                        ref final, 
                        new_show.StartTime - TimeSpan.FromMinutes(5), 
                        new_show.Duration + TimeSpan.FromMinutes(5));

                    new_show.StartTime = newTimeSpan + TimeSpan.FromMinutes(5);

                    final.Add(new_show);

                }
                else
                {
                    final.Add(new_show); 
                }

                showsPriorityP.RemoveAt(0);
            }

        }


        //vraca Adse prioriteta p i mice ih iz popisa svih Adsa
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
        //vraca Showove prioriteta p i mice ih iz popisa svih Showova
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



        



        private void ViewSchedule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "c:\\raspored.bin";
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(result_table.Columns.Count);
                bw.Write(result_table.Rows.Count);
                foreach (DataGridViewRow dgvR in result_table.Rows)
                {
                    for (int j = 0; j < result_table.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
            }

                this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void result_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
