using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TvManager.View.View
{
    using System.Windows.Forms;
    using TvManager.View.Interfaces;
    using TvManager.Model.Models;


    

    public partial class ViewSchedule : Form
    {
        


        private IShowService showService;
        private IAdService adService;
        public ViewSchedule(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

            var schedule = new Schedule();

                    
            var ads = adService.GetAds();
            var shows = showService.GetAllShows();


            var maxPriorityshows =
                from show in shows
                where show.Priority == 9 select show;

            var maxPriorityAds =
                from ad in ads
                where ad.Priority >= 8
                select ad;


            foreach (var show in maxPriorityshows)
            {
                
                //schedule.shows[show.StartTime] = show;
                listBox1.Items.Add(show.StartTime.ToString() + "  " + show.Name);

            }


            foreach (var ad in maxPriorityAds)
            {

                
                listBox1.Items.Add(ad.StartTime.ToString() + "  " + ad.Name);

            }







        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
