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
        public object lb_item = null;

        private static List<object> Emisije_i_Reklame = new List<object>();

        public static List<object> emisije_i_reklame
        {
            set {; }
            get { return Emisije_i_Reklame; }
        }



        public MainMenu(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

            FillListBox();


        }

        private void FillListBox()
        {
            MainShows.Items.Clear();
            MainAds.Items.Clear();

            var shows = showService.GetAllShows();

            foreach (var item in shows)
            {
                MainShows.Items.Add(item.Name + " " + item.StartTime + " " + item.Duration + " P:" + item.Priority);
            }

            var ads = adService.GetAds();

            foreach (var item in ads)
            {
                MainAds.Items.Add(item.Name + " " + item.StartTime + " " + item.Duration + " P:" + item.Priority);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewShows_Click(object sender, EventArgs e)
        {
            ViewShows form = new ViewShows(this.showService, this.adService);
            form.ShowDialog();

            FillListBox();
        }

        private void buttonViewAds_Click(object sender, EventArgs e)
        {
            ViewAds form = new ViewAds(this.showService, this.adService);
            form.ShowDialog();

            FillListBox();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateSchedule form = new GenerateSchedule(this.showService,this.adService);
            form.ShowDialog();

            FillListBox();
        }

        private void buttonAddAd_Click(object sender, EventArgs e)
        {
            EditAd form = new EditAd(this.showService, this.adService);
            form.ShowDialog();

            FillListBox();
        }

        private void buttonAddShow_Click(object sender, EventArgs e)
        {
            EditShow form = new EditShow(this.showService, this.adService);
            form.ShowDialog();

            FillListBox();
        }

        private void MainShows_DoubleClick(object sender, EventArgs e)
        {
            EditShow form = new EditShow(this.showService, this.adService);
            form.ShowDialog();


        }

        private void MainAds_DoubleClick(object sender, EventArgs e)
        {
            EditAd form = new EditAd(this.showService, this.adService);
            form.ShowDialog();
        }


        private void MainSchedule_DragLeave(object sender, EventArgs e)
        {

            //Draganje sa Main schedule-a mice taj item sa item_lista

            ListBox lb = sender as ListBox;
            lb_item = lb.SelectedItem;
            lb.Items.Remove(lb.SelectedItem);



        }

        private void MainSchedule_DragEnter(object sender, DragEventArgs e)
        {

            /*U MainSchedule se ubacuju elementi s lista koji su "obavezni" - mozemo im postaviti prioritet na 10+
             Nakon toga se klikne na generate schedule i on poziva sve kao i generate schedule, samo mu prenosimo ono sto
            smo ubacili u ovaj textbox s novim prioritetom
            Preneseno je u listi emisije_i_reklame koja se u GenerateSchedule i ViewSchedule prevodi u listu "obavezne"
            AKA to je obavezno da bude u rasporedu*/


            if (lb_item != null)
            {
                Emisije_i_Reklame.Add(lb_item); // lb_item je samo ime show-a/ add-a, pogledaj prvih 30 linija koda
                MainSchedule.Items.Add(lb_item);
                lb_item = null;
            }
        }

        private void MainSchedule_DragDrop(object sender, DragEventArgs e)
        {
            lb_item = null;
        }

        private void MainSchedule_DoubleClick(object sender, EventArgs e)
        {
            //Hard Edit
        }

        private void HardEdit_Click(object sender, EventArgs e)
        {
            //Hard Edit
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = MainAds.GetItemText(MainAds.SelectedItem);

            var ind = MainAds.SelectedIndex;

            var ads = adService.GetAds().ToList();

            adService.DeleteAd(ads[ind]);


            FillListBox();



        }

        private void MainAds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adService.DeleteAllAds();


            FillListBox();
        }
    }
}
