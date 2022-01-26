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
    public partial class ViewAds : Form
    {
        private IShowService showService;
        private IAdService adService;

        public ViewAds(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

            var ads = adService.GetAds();

            foreach (var item in ads)
            {
                listBox1.Items.Add(item.Name);
            }

        }

        private void ViewAds_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
