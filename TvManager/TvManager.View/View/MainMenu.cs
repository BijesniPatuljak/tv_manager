using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvManager.View.View
{
    using System.Windows.Forms;
    using TvManager.View.Interfaces;
    public partial class MainMenu : Form
    {
        private IShowService showService;
        private IAdService adService;

        public MainMenu(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewShows_Click(object sender, EventArgs e)
        {
            ViewShows form = new ViewShows(this.showService, this.adService);
            form.ShowDialog();
        }

        private void buttonViewAds_Click(object sender, EventArgs e)
        {
            ViewAds form = new ViewAds(this.showService, this.adService);
            form.ShowDialog();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateSchedule form = new GenerateSchedule(this.showService,this.adService);
            form.ShowDialog();
        }

        private void buttonAddAd_Click(object sender, EventArgs e)
        {
            EditAd form = new EditAd(this.showService, this.adService);
            form.ShowDialog();
        }

        private void buttonAddShow_Click(object sender, EventArgs e)
        {
            EditShow form = new EditShow(this.showService, this.adService);
            form.ShowDialog();
        }
    }
}
