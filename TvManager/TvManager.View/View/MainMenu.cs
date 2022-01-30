using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvManager.Model.Models;
using System.IO;

namespace TvManager.View.View
{
    using System.Windows.Forms;
    using TvManager.View.Interfaces;
    public partial class MainMenu : Form
    {
        private IShowService showService;
        private IAdService adService;
        public object lb_item = null;

        public List<Show> final_shows = new List<Show>();
        public List<Ad> final_ads = new List<Ad>();


        bool zastava = false;


        public MainMenu(IShowService showService, IAdService adService)
        {
            this.showService = showService;
            this.adService = adService;
            InitializeComponent();

            FillListBox();


        }

        private void FillListBox()
        {
            //MainShows.Items.Clear();
            //MainAds.Items.Clear();
            //MainSchedule.Items.Clear();
            result_table.Rows.Clear();
            show_table.Rows.Clear();
            table_ads.Rows.Clear();


            var shows = showService.GetAllShows();

            foreach (var item in shows)
            {
                //MainShows.Items.Add(item.Name + " " + item.StartTime + " " + item.Duration + " P:" + item.Priority);

                string[] row = { item.Name, item.StartTime.ToString(), item.Duration.ToString() };

                show_table.Rows.Add(row);



            }

            var ads = adService.GetAds();

            foreach (var item in ads)
            {
                //MainAds.Items.Add(item.Name + " " + item.StartTime + " " + item.Duration + " P:" + item.Priority);
                string[] row = { item.Name, item.StartTime.ToString(), item.Duration.ToString() };

                table_ads.Rows.Add(row);

            }



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
                //MainSchedule.Items.Add(ad.StartTime.ToString() + " " + ad.Duration.ToString() + " AD " + ad.Name + " P:" + ad.Priority);
            }

            result_table.Sort(result_table.Columns["ResultStartTime"], ListSortDirection.Ascending);
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
            ViewSchedule form = new ViewSchedule(this.showService,this.adService);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                final_ads = form.final_ads;           
                final_shows = form.final_shows;
                
            }

            FillListBox();
            zastava = true;
            HardEdit.Enabled = true;
            buttonSave.Enabled = true;
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


        private void MainSchedule_DoubleClick(object sender, EventArgs e)
        {
            if (zastava)
            {
                ViewSchedule form = new ViewSchedule(this.showService, this.adService);
                form.ShowDialog();

            }
            //Hard Edit
        }

        private void HardEdit_Click(object sender, EventArgs e)
        {
            ViewSchedule form = new ViewSchedule(this.showService, this.adService);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var ind = table_ads.SelectedRows[0];

            var ads = adService.GetAds().ToList();

            adService.DeleteAd(ads[ind.Index]);


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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delete_show_Click(object sender, EventArgs e)
        {

            //var ind = MainShows.SelectedIndex;
            var ind = show_table.SelectedRows[0];

            var shows = showService.GetAllShows().ToList();

            showService.DeleteShow(shows[ind.Index]);


            FillListBox();
        }

        private void delete_all_shows_Click(object sender, EventArgs e)
        {
            showService.DeleteAllShows();
            FillListBox();
        }

        private void MainSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void result_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void table_ads_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void result_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
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
    }
}
