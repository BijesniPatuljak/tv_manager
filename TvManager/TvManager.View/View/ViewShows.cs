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
    public partial class ViewShows : Form
    {
        private IShowService showService;
        private IAdService adService;

        public ViewShows(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

            var shows = showService.GetAllShows();

            foreach (var item in shows)
            {
                listBox1.Items.Add(item.Name);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ViewShows_Load(object sender, EventArgs e)
        {

        }

        private void AddShow_Click(object sender, EventArgs e)
        {
            ViewShows form = new ViewShows(this.showService, this.adService);
            form.ShowDialog();
        }
    }
}
