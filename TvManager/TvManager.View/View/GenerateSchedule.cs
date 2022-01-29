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
    public partial class GenerateSchedule : Form
    {
        private IShowService showService;
        private IAdService adService;
        public GenerateSchedule(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

            var ads = adService.GetAds();

            foreach (var item in ads)
            {
                listView2.Items.Add(item.Name + " " + item.Cost.ToString() + " " + item.Duration.ToString("mm':'ss"));
            }

            var shows = showService.GetAllShows();

            foreach (var item in shows)
            {
                listBox1.Items.Add(item.Name + " " + item.StartTime.ToString("hh':'mm") + " P:" + item.Priority.ToString());
            }
        }

        private void GenerateSchedule_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            ViewSchedule form = new ViewSchedule(this.showService, this.adService);
            form.ShowDialog();
        }
    }
}
